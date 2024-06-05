using Barker.Models;
using Microsoft.EntityFrameworkCore;

namespace Barker
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        // Добавьте DbSet для каждой модели, которую вы хотите включить в базу данных
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}