// WindowsApi
// Copyright (C) 2020-2023 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Parser;

internal class Program
{
    /// <summary>
    /// This program was used to parse the System Error Codes from this pages:
    /// https://learn.microsoft.com/en-us/windows/win32/debug/system-error-codes--0-499-
    /// https://learn.microsoft.com/en-us/windows/win32/debug/system-error-codes--500-999-
    /// etc...
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        string[] inputFilePaths =
        {
            "input-01-0-499.txt",
            "input-02-500-999.txt",
            "input-03-1000-1299.txt",
            "input-04-1300-1699.txt",
            "input-05-1700-3999.txt",
            "input-06-4000-5999.txt",
            "input-07-6000-8199.txt",
            "input-08-8200-8999.txt",
            "input-09-9000-11999.txt",
            "input-10-13000-15999.txt",
        };

        var lines = inputFilePaths
            .SelectMany(File.ReadLines)
            .Select(x => x.Trim());

        var records = ReadRecords(lines);

        var outputFilePath = "output.txt";
        using var streamWriter = new StreamWriter(outputFilePath);

        foreach (var record in records)
            streamWriter.WriteLine(record.ToString());

        streamWriter.Flush();
    }

    private static IEnumerable<Record> ReadRecords(IEnumerable<string> lines)
    {
        var step = StructureStep.BeforeName;
        var record = new Record();

        foreach (var line in lines)
        {
            if (step == StructureStep.BeforeName)
            {
                if (line.Length == 0)
                    continue;

                step = StructureStep.Name;
            }

            if (step == StructureStep.Name)
            {
                NameLine nameLine = new(line);
                record.OriginalName = nameLine.OriginalName;
                record.Name = nameLine.ToPascalCase();

                step = StructureStep.BeforeValue;

                continue;
            }

            if (step == StructureStep.BeforeValue)
            {
                if (line.Length == 0)
                    continue;

                step = StructureStep.Value;
            }

            if (step == StructureStep.Value)
            {
                ValueLine valueLine = new(line);
                record.Value = valueLine.HexaValue;

                step = StructureStep.BeforeDescription;
                continue;
            }

            if (step == StructureStep.BeforeDescription)
            {
                if (line.Length == 0)
                    continue;

                step = StructureStep.Description;
            }

            if (step == StructureStep.Description)
            {
                if (line.Length == 0)
                {
                    yield return record;
                    record = new Record();

                    step = StructureStep.BeforeName;
                }
                else
                {
                    DescriptionLine descriptionLine = new(line);
                    record.Description.Add(descriptionLine.Line);
                }

                continue;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}