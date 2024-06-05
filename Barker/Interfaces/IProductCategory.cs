using System.Collections.Generic;
using Barker.Models;

namespace Barker.Interfaces
{
    public interface IProductCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
