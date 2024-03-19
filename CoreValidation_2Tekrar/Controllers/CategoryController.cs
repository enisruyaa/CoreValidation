using CoreValidation_2Tekrar.Models.ContextClasses;
using CoreValidation_2Tekrar.Models.Entities;
using CoreValidation_2Tekrar.Models.ViewModels.PureVM.Categories;
using Microsoft.AspNetCore.Mvc;

namespace CoreValidation_2Tekrar.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;

        public CategoryController(MyContext db)
        {
            _db = db;
        }

        public IActionResult GetCategories()
        {
            return View();
        }

        public IActionResult CreateCategory()
        {
            return View();        
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryRequestModel category)
        {
            // Server Side Valiation'da bilgliler back end'e gönderilir ve kontrol öyle sağlanır.
            if (ModelState.IsValid) // Model Durumu Validdation'dan Geçmiş ise
            {
                Category c = new()
                {
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };
                _db.Categories.Add(c);
                _db.SaveChanges();
                return RedirectToAction("GetCategories");
            }

            return View(category);
        }
    }
}
