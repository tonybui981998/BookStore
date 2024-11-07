using BookStore.Models;
using BookStore.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _db;
        public ProductController(IUnitOfWork db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> objProduct = _db.Product.GetAll().ToList();
            
            return View(objProduct);
        }
    }
}
