using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            return string.Empty;

        identifier = identifier.Trim();
        bool flag = false;
        var cleaned = new StringBuilder();
        foreach (var c in identifier)
        {
            if (c >= 'α' && c <= 'ω')
                continue;
            if (c == ' ')
                cleaned.Append('_');
            if (char.IsLetter(c) && !flag || c == '_')
                cleaned.Append(c);
            if (c == '\0')
                cleaned.Append("CTRL");
            if (c == '-')
            {
                flag = true;
                continue;
            }
            if (flag && char.IsLetter(c))
            {
                cleaned.Append(char.ToUpper(c));
                flag = false;
            }
            if (char.IsDigit(c))
                continue;
        }

        // Remove leading/trailing underscores
        return cleaned.ToString();
    }
}
