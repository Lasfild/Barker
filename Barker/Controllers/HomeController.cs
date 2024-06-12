using Barker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
