using Barker.DataAccess.Repository.IRepository;
using Barker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Barker.DataAccess.Repository
{
    public class CategoryRepository : Repository<CategoryModel>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CategoryModel category)
        {
            _db.Categories.Update(category);
        }
    }
}
