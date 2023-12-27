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