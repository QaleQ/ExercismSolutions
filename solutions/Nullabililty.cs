using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idPart = id == null ? "" : $"[{id}] - ";
        string departmentPart = department == null ? "OWNER" : department.ToUpper();
        return $"{idPart}{name} - {departmentPart}";
    }
}