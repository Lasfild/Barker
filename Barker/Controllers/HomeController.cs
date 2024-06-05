using Barker.Interfaces;
using Barker.Models;
using Barker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Barker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _productRepo;

        public HomeController(IAllProducts productRepo)
        {
            _productRepo = productRepo;
        }

        public IActionResult List()
        {
            var products = _productRepo.Products;
            if (products == null || !products.Any())
            {
                return View("Error"); // Отобразить страницу ошибки, если нет продуктов
            }
            return View(products);
        }

        public IActionResult Index()
        {
            var HomeProducts = new HomeViewModel
            {
                favProducts = _productRepo.Products
            };
            return View(HomeProducts);
        }
    }
}
