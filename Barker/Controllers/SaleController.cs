using Microsoft.AspNetCore.Mvc;

namespace Barker.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
