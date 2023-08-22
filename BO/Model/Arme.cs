using System.Runtime.Serialization;

namespace BO.Model;

public class Arme
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;
    public double Degats { get; set; }
    
    public int? IdUtilisateur { get; set; }
    public Samourai? Utilisateur { get; set; }
}