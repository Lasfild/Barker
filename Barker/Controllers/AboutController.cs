using Microsoft.AspNetCore.Mvc;

namespace Barker.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
