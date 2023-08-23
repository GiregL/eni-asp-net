using BO.Model;

namespace ArmesWebAPI.DTOs.Armes;

/// <summary>
/// DTO renvoyé a l'utilisateur pour les armes.
/// </summary>
public class ArmesDTO
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public double Degats { get; set; }
    public int? IdUtilisateur { get; set; }
}

public static class ArmesDTOExt
{
    public static ArmesDTO ConvertToArmesDTO(this Arme arme)
    {
        return new ArmesDTO()
        {
            Id = arme.Id,
            Nom = arme.Nom,
            Degats = arme.Degats,
            IdUtilisateur = arme.IdUtilisateur
        };
    }

    public static Arme FromArmesDTO(this ArmesDTO arme)
    {
        return new Arme()
        {
            Id = arme.Id,
            Nom = arme.Nom,
            Degats = arme.Degats,
            IdUtilisateur = arme.IdUtilisateur
        };
    }
}