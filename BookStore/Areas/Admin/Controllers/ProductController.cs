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
        // get all product
        public IActionResult Index()
        {
            List<Product> objProduct = _db.Product.GetAll().ToList();

            return View(objProduct);
        }
        
        public IActionResult CreateNew()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNew(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Product.Add(product);
                _db.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        // delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var getId = _db.Product.Get(u => u.Id == id);
            if (getId == null) { 
            return NotFound();
            }
            _db.Product.Remove(getId);
            _db.Save();
            return RedirectToAction("Index");
        }
        /// edit
        public IActionResult Edit(int id) { 
            Product getProduct = _db.Product.Get(u=>u.Id == id);
            if (getProduct == null) {
                return NotFound();
            }
        return View(getProduct);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid) {
                return NotFound();
            }
            _db.Product.Update(product);
            _db.Save();

            return RedirectToAction("Index");
           
        }
    }
}

