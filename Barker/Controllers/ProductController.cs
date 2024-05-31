using Barker.Interfaces;
using Barker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Barker.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProducts _AllProducts;
        private readonly IProductCategory _AllCategories;

        public ProductController(IAllProducts IAllProducts, IProductCategory IAllCategories)
        {
            _AllProducts = IAllProducts;
            _AllCategories = IAllCategories;
        }

        public ActionResult List()
        {
            ProductListViewModel obj = new ProductListViewModel();
            obj.AllProducts = _AllProducts.Products;
            obj.CurrentCategory = "Ding Dong";

            return View(obj);
        }
    }
}
