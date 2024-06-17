using Barker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barker.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<ProductModel>
    {
        void Update(ProductModel product);
    }
}
