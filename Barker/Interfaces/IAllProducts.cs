using Barker.Models;

namespace Barker.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get;  }
        IEnumerable<Product> IsOnMainProducts { get; }
        Product ProductId(int productId);
    }
}
