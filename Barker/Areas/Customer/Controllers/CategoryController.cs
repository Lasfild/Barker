using Barker.DataAccess.Repository.IRepository;
using Barker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Barker.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var categories = _unitOfWork.Category.GetAll().ToList();
            return View(categories);
        }

        public IActionResult Category(string name)
        {
            var category = _unitOfWork.Category.Get(c => c.Name.ToLower() == name.ToLower());
            if (category != null)
            {
                var products = _unitOfWork.Product.GetAll(p => p.CategoryId == category.Id).ToList();
                return View(products);
            }

            return NotFound();
        }
    }
}
