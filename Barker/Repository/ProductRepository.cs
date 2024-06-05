using Barker.Interfaces;
using Barker.Models;

namespace Barker.Repositories
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent _appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Product> Products => _appDBContent.Products;

        public IEnumerable<Product> IsOnMainProducts => _appDBContent.Products.Where(p => p.Sale);

        public Product ProductId(int productId) => _appDBContent.Products.FirstOrDefault(p => p.Id == productId);
    }
}