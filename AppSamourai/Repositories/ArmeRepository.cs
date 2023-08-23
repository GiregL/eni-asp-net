using AppSamourai.Data;
using BO.Model;

namespace TpEni.Repositories;

public class ArmeRepository
{
    private SamouraiDbContext _context;
    public ArmeRepository(SamouraiDbContext context)
    {
        _context = context;
    }

    public Arme? GetById(int id)
    {
        return _context.Armes.SingleOrDefault(arme => arme.Id == id);
    }

    public Arme Delete(Arme arme)
    {
        return _context.Armes.Remove(arme).Entity;
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public IEnumerable<Arme> GetWhere(Func<Arme, bool> predicate)
    {
        return _context.Armes.Where(predicate);
    }

    public IEnumerable<Arme> GetAll()
    {
        return _context.Armes;
    }

    public Arme Update(Arme arme)
    {
        return _context.Update(arme).Entity;
    }

    public Arme Add(Arme arme)
    {
        return _context.Armes.Add(arme).Entity;
    }
}