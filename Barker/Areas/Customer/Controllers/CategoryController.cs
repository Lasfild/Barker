using Microsoft.AspNetCore.Mvc;
using Barker.Models;

namespace Barker.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<CategoryModel> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Anniversary()
        {
            var category = _db.Categories.FirstOrDefault(c => c.Name == "Anniversary");
            if (category != null)
            {
                var products = _db.Products.Where(p => p.CategoryId == category.Id).ToList();
                return View(products);
            }

            return NotFound();
        }

        public IActionResult Handcrafted()
        {
            var category = _db.Categories.FirstOrDefault(c => c.Name == "Handcrafted");
            if (category != null)
            {
                var products = _db.Products.Where(p => p.CategoryId == category.Id).ToList();
                return View(products);
            }

            return NotFound();
        }
    }
}
