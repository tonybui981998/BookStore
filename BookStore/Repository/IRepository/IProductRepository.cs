using BookStore.Models;

namespace BookStore.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Remove(Product getId);
        void Update(Product product);
      
      
    }
}
