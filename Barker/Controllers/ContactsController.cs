using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Barker.Controllers
{
    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
