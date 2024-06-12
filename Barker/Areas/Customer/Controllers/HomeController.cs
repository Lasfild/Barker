using Barker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barker.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Sale()
        {
            return View();
        }
    }
}
