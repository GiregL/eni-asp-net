namespace BO.Model;

public class ArtMartialSamourai
{
    public int ArtMartialsId { get; set; }
    public int SamouraisId { get; set; }

    public Samourai Samourai { get; set; } = null!;
    public ArtMartial ArtMartial { get; set; } = null!;
}