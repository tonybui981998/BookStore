using BookStore.Data;
using BookStore.Models;
using BookStore.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CatergoryController : Controller
    {
        private readonly IUnitOfWork _db;
        public CatergoryController(IUnitOfWork db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> ObjectCategory = _db.Category.GetAll().ToList();
            return View(ObjectCategory);
        }
        public IActionResult CreateNew()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNew(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The name and display order can't be the same");
            }
            if (obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "test is invalid value");
            }


            if (ModelState.IsValid)
            {
                _db.Category.Add(obj);
                _db.Save();
                return RedirectToAction("Index");
            }
            return View();


        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category categoryFrommDb = _db.Category.Get(u => u.Id == id);
            if (categoryFrommDb == null) { return NotFound(); }
            return View(categoryFrommDb);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Category.Update(category);
                _db.Save();
                return RedirectToAction("Index");
            }
            return View();


        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var getId = _db.Category.Get(u => u.Id == id);
            if (getId == null)
            {
                return NotFound();
            }
            _db.Category.Remove(getId);
            _db.Save();
            return RedirectToAction("Index");
        }
    }
}
