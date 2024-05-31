using Barker.Interfaces;
using Barker.Models;
using System.Collections.Generic;
using System.Linq;

namespace Barker.Mocks
{
    public class MockProduct : IAllProducts
    {
        private readonly IProductCategory _categoryProducts = new MockCategory();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product { 
                        Name = "Product1",
                        Description = "Description1",
                        ShortDescription = "ShortDescription1",
                        Price = 15000,
                        IsOnMain = true,
                        Img = "https://img.freepik.com/free-photo/cosmetic-bottle_74190-4837.jpg?size=626&ext=jpg", 
                        Availability = true, 
                        Category = _categoryProducts.AllCategories.First() },

                    new Product
                    { 
                        Name = "Product2",
                        Description = "Description2",
                        ShortDescription = "ShortDescription2",
                        Price = 25000,
                        IsOnMain = false,
                        Img = "https://img.freepik.com/free-psd/cosmetic-bottle-container-isolated_23-2151352942.jpg?size=626&ext=jpg",
                        Availability = false,
                        Category = _categoryProducts.AllCategories.ElementAt(1) },

                    new Product
                    { 
                        Name = "Product3",
                        Description = "Description3",
                        ShortDescription = "ShortDescription3", 
                        Price = 35000,
                        IsOnMain = false,
                        Img = "https://img.freepik.com/free-psd/body-wash-bottle-isolated-transparent-background_191095-25909.jpg?size=626&ext=jpg",
                        Availability = true,
                        Category = _categoryProducts.AllCategories.ElementAt(2) },

                    new Product 
                    { 
                        Name = "Product4",
                        Description = "Description4",
                        ShortDescription = "ShortDescription4",
                        Price = 45000,
                        IsOnMain = true,
                        Img = "https://img.freepik.com/free-psd/skin-product-isolated_23-2151353672.jpg?size=626&ext=jpg",
                        Availability = true, 
                        Category = _categoryProducts.AllCategories.Last() },
                };
            }
        }

        public IEnumerable<Product> IsOnMainProducts => Products.Where(p => p.IsOnMain);

        public Product ProductId(int productId)
        {
            return Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
