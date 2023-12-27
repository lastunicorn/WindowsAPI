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