using Barker.DataAccess.Repository.IRepository;
using Barker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barker.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Product(string name)
        {
            var product = _unitOfWork.Product.Get(u => u.Name == name);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}