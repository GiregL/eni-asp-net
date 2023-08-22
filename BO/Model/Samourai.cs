using AppSamourai.Data;

namespace BO.Model;

public class Samourai : EntityBase
{
    
    public string Nom { get; set; } = null!;
    
    public int Force { get; set; }
    
    public int? IdArme { get; set; }
    public Arme? Arme { get; set; }
}