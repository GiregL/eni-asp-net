using System.Runtime.Serialization;
using AppSamourai.Data;

namespace BO.Model;

public class Arme : EntityBase
{

    public string Nom { get; set; } = null!;
    public double Degats { get; set; }
    
    public int? IdUtilisateur { get; set; }
    public Samourai? Utilisateur { get; set; }
}