using Barker.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Barker.Models;

namespace Barker.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductCategory _categoryRepository;

        public CategoryController(IProductCategory categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            IEnumerable<Category> categories = _categoryRepository.AllCategories;
            return View(categories);
        }
    }
}
