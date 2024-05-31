using Barker.Interfaces;
using Barker.Models;

namespace Barker.Mocks
{
    public class MockCategory : IProductCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Categoryname 1", Description = "Description 1" },
                    new Category { Name = "Categoryname 2", Description = "Description 2" },
                    new Category { Name = "Categoryname 3", Description = "Description 3" },
                    new Category { Name = "Categoryname 4", Description = "Description 4" }
                };
            }
        }
    }
}
