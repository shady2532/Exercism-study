static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if(id == null)
        {
            return $"{name} - {(department ?? "OWNER").ToUpper()}".Trim();
        }
        return $"[{id ?? 0}] - {name} - {(department ?? "OWNER").ToUpper()}".Trim();
    }
}
