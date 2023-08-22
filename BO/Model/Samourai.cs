namespace BO.Model;

public class Samourai
{
    public int Id { get; set; }
    
    public string Nom { get; set; } = null!;
    
    public int Force { get; set; }
    
    public int? IdArme { get; set; }
    public Arme? Arme { get; set; }
}