using AppSamourai.Data;
using BO.Model;

namespace TpEni.Repositories;

public class SamouraiRepository
{
    private readonly SamouraiDbContext _context;

    public SamouraiRepository(SamouraiDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Samourai> GetAll()
    {
        return _context.Samourais;
    }

    public Samourai Add(Samourai samourai)
    {
        return _context.Samourais.Add(samourai).Entity;
    }
}