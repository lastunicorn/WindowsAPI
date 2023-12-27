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

internal readonly struct NameLine
{
    private readonly string[] words;

    public string OriginalName { get; }

    public NameLine(string line)
    {
        OriginalName = line;
        words = line.Split("_");
    }

    public string ToPascalCase()
    {
        IEnumerable<string> meaningfulWords = words
            .Where((x, i) => i != 0 || x != "ERROR")
            .Select(ToPascalCase);

        return string.Join(string.Empty, meaningfulWords);
    }

    private static string ToPascalCase(string word)
    {
        IEnumerable<char> chars = word
            .Select((x, i) => i == 0 ? char.ToUpper(x) : char.ToLower(x));

        return string.Join(string.Empty, chars);
    }
}