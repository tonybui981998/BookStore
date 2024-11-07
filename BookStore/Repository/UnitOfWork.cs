using BookStore.Data;
using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

 
        public IProductRepository Product { get; private set; }
        public ICategoryRepository Category {  get; private set; }  

        //public ICategoryRepository Category => throw new NotImplementedException();

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }
      

        public void Save()
        {
            _db.SaveChanges();
        }
      
    }
}
