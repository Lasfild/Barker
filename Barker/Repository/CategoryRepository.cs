using System.Collections.Generic;
using Barker.Interfaces;
using Barker.Models;

namespace Barker.Repositories
{
    public class CategoryRepository : IProductCategory
    {
        private readonly AppDBContent _appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => _appDBContent.Categories;
    }
}
