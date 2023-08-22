using AppSamourai.Data;
using BO.Model;

namespace TpEni.Repositories;

public class ArmeRepository : CrudRepository<Arme, SamouraiDbContext>
{
    public ArmeRepository(SamouraiDbContext context) : base(context)
    {
    }
}