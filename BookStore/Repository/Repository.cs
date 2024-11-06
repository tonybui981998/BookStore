using BookStore.Data;
using BookStore.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;

//namespace BookStore.Repository;


public class Repository<T> : IRepository<T> where T : class
{
    public readonly ApplicationDbContext _db;
    internal DbSet<T> dbSet;
    public Repository(ApplicationDbContext db)
    {
        _db = db;   
        this.dbSet = _db.Set<T>();


    }
    public void Add(T entity)
    {
        dbSet.Add(entity);
      
    }

    public void Delete(T entity)
    {
        dbSet?.Remove(entity);
    }

    public void DeleteRange(IEnumerable<T> entity)
    {
       dbSet.RemoveRange(entity);
    }

    public T Get(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = dbSet;
        query= query.Where(filter);
        return query.FirstOrDefault();
    }

    public IEnumerable<T> GetAll()
    {
        IQueryable<T> query = dbSet;
        return query.ToList();
    }

    public T GetFirstOrDefault()
    {
        throw new NotImplementedException();
    }
}
