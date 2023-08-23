namespace BO.Model;

public class ArtMartial
{
    public int Id { get; set; }
    public string Nom { get; set; } = null!;
    public List<Samourai> Utilisateurs { get; } = new();
}