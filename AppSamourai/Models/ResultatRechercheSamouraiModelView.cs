using BO.Model;

namespace TpEni.Models;

/// <summary>
/// Résultats d'une recherche de samourais.
/// </summary>
public class ResultatRechercheSamouraiModelView : CriteresRechercheSamourai
{
    public ICollection<Samourai> ResultatRecherche { get; set; }
}