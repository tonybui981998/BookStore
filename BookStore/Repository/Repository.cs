using BookStore.Data;
using BookStore.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
        
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public void DeleteRange(IEnumerable<T> entity)
    {
        throw new NotImplementedException();
    }

    public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetFirstOrDefault()
    {
        throw new NotImplementedException();
    }
}
