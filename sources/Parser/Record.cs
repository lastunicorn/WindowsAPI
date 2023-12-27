using System.Text;

namespace Parser;

internal class Record
{
    public string Name { get; set; }

    public string OriginalName { get; set; }

    public string Value { get; set; }

    public List<string> Description { get; } = new();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("/// <summary>");
        sb.AppendLine("/// " + OriginalName);

        foreach (string descriptionLine in Description)
            sb.AppendLine("/// " + descriptionLine);

        sb.AppendLine("/// </summary>");
        sb.AppendLine($"{Name} = {Value},");

        return sb.ToString();
    }
}