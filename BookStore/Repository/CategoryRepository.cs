using BookStore.Data;
using BookStore.Models;
using BookStore.Repository.IRepository;
using System.Linq.Expressions;

namespace BookStore.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
      

        public void Update(Category category)
        {
         _db.Categories.Update(category);
        }
        public void Remove(Category category)
        {
           _db.Categories.Remove(category);
        }
    }
}
