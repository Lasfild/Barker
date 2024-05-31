using Barker.Models;

namespace Barker.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> AllProducts {  get; set; }

        public string CurrentCategory { get; set; }
    }
}
