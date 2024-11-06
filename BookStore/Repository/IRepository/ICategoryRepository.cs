using BookStore.Models;

namespace BookStore.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Remove(Category getId);
        void Update(Category category);
      
      
    }
}
