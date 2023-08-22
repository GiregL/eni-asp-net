using AppSamourai.Data;
using BO.Model;

namespace TpEni.Repositories;

public class SamouraiRepository : CrudRepository<Samourai, SamouraiDbContext>
{
    public SamouraiRepository(SamouraiDbContext context) : base(context)
    {
    }
}