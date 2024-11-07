using BookStore.Data;
using BookStore.Models;
using BookStore.Repository.IRepository;
using System.Linq.Expressions;

namespace BookStore.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
      

        public void Update(Product product)
        {
         _db.Products.Update(product);
        }
        public void Remove(Product product)
        {
           _db.Products.Remove(product);
        }
    }
}
