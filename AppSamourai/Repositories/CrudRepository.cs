using AppSamourai.Data;
using Microsoft.EntityFrameworkCore;

namespace TpEni.Repositories;

public abstract class CrudRepository<T, TContext> 
    where TContext : DbContext
    where T : EntityBase
{
    protected readonly TContext Context;

    protected CrudRepository(TContext context)
    {
        Context = context;
    }

    private DbSet<T> GetDbSet()
    {
        return (DbSet<T>) typeof(TContext)
            .GetProperty(typeof(T).Name + "s")
            !.GetValue(GetContext())!;
    }
    
    public virtual T? GetById(int id)
    {
        return GetDbSet().SingleOrDefault(t => t.Id == id);
    }

    public virtual IEnumerable<T> GetAll()
    {
        return GetDbSet();
    }

    public virtual IEnumerable<T> GetWhere(Func<T, bool> predicate)
    {
        return GetDbSet().Where(predicate);
    }

    public virtual T Add(T t)
    {
        return GetDbSet().Add(t).Entity;
    }
    
    public virtual T Update(T t)
    {
        return GetDbSet().Update(t).Entity;
    }

    public virtual T Delete(T t)
    {
        return GetDbSet().Remove(t).Entity;
    }

    public void Save()
    {
        GetContext().SaveChanges();
    }

    protected virtual TContext GetContext()
    {
        return Context;
    }
}