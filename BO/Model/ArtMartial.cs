namespace BO.Model;

public class ArtMartial
{
    public int Id { get; set; }
    public string Nom { get; set; } = null!;
    public ICollection<Samourai> Utilisateurs { get; set; }
}