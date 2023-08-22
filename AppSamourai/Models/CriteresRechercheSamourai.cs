namespace TpEni.Models;

/// <summary>
/// Critères de recherche dans la liste des samourais
/// </summary>
public class CriteresRechercheSamourai
{
    public const int NB_ELEM_PAR_PAGE_DEFAUT = 7;

    public string? NomSamourai { get; set; }

    public int? Page { get; set; }

    public int? NbElemParPage { get; set; }

    public SensTri? SensTriSamourais { get; set; }

    public ChampTriSamourai? ChampTri { get; set; }
    
    public bool? ResetCriteres { get; set; }
}