using System.Reflection;

namespace TpEni.Models;

public enum SensTri
{
    ASCENDANT,
    DESCENDANT,
}

public static class ExtensionSensTri
{
    public static MethodInfo MethodeLinqOrderBy<T>(this SensTri? sensTri)
    {
        if (sensTri == SensTri.ASCENDANT)
        {
            return typeof(IQueryable<T>).GetMethod("OrderBy")!;
        }
        return typeof(IQueryable<T>).GetMethod("OrderByDescending")!;
    }
}