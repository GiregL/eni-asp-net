using BO.Model;

namespace ArmesWebAPI.DTOs.Samourais;

public class SamouraisDTO
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public int Force { get; set; }
    public int? IdArme { get; set; }
    public List<int> IdsTechniques { get; set; } = new();
}

public static class SamouraisDTOExt
{
    
    public static SamouraisDTO FromSamourai(this Samourai samourai)
    {
        return new SamouraisDTO()
        {
            Id = samourai.Id,
            Nom = samourai.Nom,
            Force = samourai.Force,
            IdArme = samourai.IdArme,
            IdsTechniques = samourai.Techniques.ConvertAll(am => am.Id)
        };
    }

    /// <summary>
    /// Ne récupère pas les techniques d'art martiaux.
    /// </summary>
    /// <param name="samouraisDto"></param>
    /// <returns></returns>
    public static Samourai ToSamourai(this SamouraisDTO samouraisDto)
    {
        return new Samourai()
        {
            Id = samouraisDto.Id,
            Nom = samouraisDto.Nom,
            Force = samouraisDto.Force,
            IdArme = samouraisDto.IdArme,
        };
    }
}