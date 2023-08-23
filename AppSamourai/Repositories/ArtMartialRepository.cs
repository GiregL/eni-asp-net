using AppSamourai.Data;
using BO.Model;

namespace TpEni.Repositories;

public class ArtMartialRepository
{
    private readonly SamouraiDbContext _context;

    public ArtMartialRepository(SamouraiDbContext context)
    {
        _context = context;
    }

    public IEnumerable<ArtMartial> GetAll()
    {
        return _context.ArtMartials;
    }

    public IEnumerable<ArtMartial> GetAllOfSamourai(Samourai samourai)
    {
        return _context.ArtMartialSamourais
            .Where(ams => ams.SamouraisId == samourai.Id)
            .Select(ams => ams.ArtMartial);
    }

    public void RemoveAMOfSamourai(Samourai samourai, ArtMartial artMartial)
    {
        RemoveRangeOfAMOfSamourai(samourai, new List<ArtMartial>() {artMartial});
    }
    
    public void RemoveRangeOfAMOfSamourai(Samourai samourai, IEnumerable<ArtMartial> artMartials)
    {
        _context.ArtMartialSamourais.RemoveRange(
            _context.ArtMartialSamourais
                .Join(artMartials,
                    ams => ams.ArtMartialsId,
                    am => am.Id,
                    (ams, am) => new { Ams = ams, Am = am })
                .Where(group => group.Ams.SamouraisId == samourai.Id)
                .Select(group => group.Ams)
            );
    }

    public void AddManyToSamourai(Samourai samourai, IEnumerable<ArtMartial> artMartials)
    {
        _context.ArtMartialSamourais.AddRange(
            artMartials.Select(am => new ArtMartialSamourai()
            {
                ArtMartial = am,
                ArtMartialsId = am.Id,
                Samourai = samourai,
                SamouraisId = samourai.Id
            }));
    }
}