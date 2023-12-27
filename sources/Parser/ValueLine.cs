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

using System.Text.RegularExpressions;

namespace Parser;

internal readonly struct ValueLine
{
    private static readonly Regex Regex = new(@"(\d+)\s*\((.*)\)", RegexOptions.IgnoreCase | RegexOptions.Multiline);

    public string IntValue { get; }

    public string HexaValue { get; }

    public ValueLine(string line)
    {
        Match match = Regex.Match(line);

        if (!match.Success)
            throw new Exception("Value line was invalid.");

        IntValue = match.Groups[1].Value;
        HexaValue = match.Groups[2].Value;
    }
}