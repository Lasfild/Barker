using Barker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barker.ViewModels
{
    public class HomeViewModel : Controller
    {
        public IEnumerable<Product> favProducts { get; set; }
    }
}
