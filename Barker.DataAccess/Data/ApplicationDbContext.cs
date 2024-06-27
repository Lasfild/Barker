using Barker.Models;
using Microsoft.EntityFrameworkCore;

namespace Barker
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    Id = 1,
                    Name = "anniversary",
                    Description = "Вершина якості",
                    Img = "/img/category_img/barker_cat_anniv.jpg",
                },
                new CategoryModel
                {
                    Id = 2,
                    Name = "handcrafted",
                    Description = "Ручна робота",
                    Img = "/img/category_img/barker_cat_handc.jpg",
                },
                new CategoryModel
                {
                    Id = 3,
                    Name = "country",
                    Description = "Потовщена підошва",
                    Img = "/img/category_img/barker_cat_country.jpg",
                },
                new CategoryModel
                {
                    Id = 4,
                    Name = "creative",
                    Description = "Сучасний дизайн",
                    Img = "/img/category_img/barker_cat_creative.jpg",
                },
                new CategoryModel
                {
                    Id = 5,
                    Name = "barkerflex",
                    Description = "Гнучкі та легкі",
                    Img = "/img/category_img/barker_cat_flex.jpg",
                },
                new CategoryModel
                {
                    Id = 6,
                    Name = "professional",
                    Description = "Класика поза часом",
                    Img = "/img/category_img/barker_cat_prof.jpg",
                },
                new CategoryModel
                {
                    Id = 7,
                    Name = "moccasin",
                    Description = "Винятковий комфорт",
                    Img = "/img/category_img/mocc-category_2.jpg",
                },
                new CategoryModel
                {
                    Id = 8,
                    Name = "accessory",
                    Description = "Стильні та якісні аксесуари",
                    Img = "/img/category_img/accesory_cat.jpg",
                }
                );

            modelBuilder.Entity<ProductModel>().HasData(
                new ProductModel
                {
                    Id = 1,
                    CategoryId = 2,
                    Name = "Lerwick Antique Rosewood",
                    VendorCode = "431527",
                    Price = 21400,
                    SalePrice = 17000,
                    Style = "оксфорд",
                    Shoe = 464,
                    Fullness = "G",
                    SoleMethod = "рантовий",
                    Sole = "шкіра",
                    Country = "Англія",
                    TopMaterial = "Натуральна шкіра",
                    Size = new List<double> { 6, 8.5, 9 },
                    Color = "ROSEWOOD",
                    IsAvailable = false,
                    IsOnSale = false,
                    Description = "Колекція Handcrafted - це вершина майстерності англійських майстрів фабрики Barker. Історичний текст, вигравіюваний на шкіряній підошві - це дуже вишукано! Відрізний носок з перфорацією та довгий вінгтіп посилює враження.",
                    Img = new List<string> { "/img/product_Img/AntiqueRosewood/Lerwick-431527_AntiqueRosewood_1080x.png", "/img/product_img/AntiqueRosewood/Lerwick_431527_AntiqueRosewoodCalf_side_1024x6002x.png", "/img/product_img/AntiqueRosewood/Lerwick_431527_AntiqueRosewood_top_1024x6002x.png", "/img/product_img/AntiqueRosewood/Rochester_380417_7mm_Leather_464Last_1024x6002x.png" }
                },
                new ProductModel
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Alderney-Rosewood",
                    VendorCode = "322026",
                    Price = 21400,
                    SalePrice = 17000,
                    Style = "оксфорд",
                    Shoe = 396,
                    Fullness = "FX",
                    SoleMethod = "рантовий",
                    Sole = "шкіра",
                    Country = "Англія",
                    TopMaterial = "Натуральна шкіра",
                    Size = new List<double> { 9, 10, 12 },
                    Color = "ROSEWOOD",
                    IsAvailable = true,
                    IsOnSale = true,
                    Description = "Бездоганні оксфорди із одного цільного шматка шкіри, ручна робота, Goodyear welted, дизайн та виробництво - Англія. Ювілейна колекція. В наявності і в чорному кольорі.",
                    Img = new List<string> { "/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf.png", "/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf_side.png", "/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf_top.png", "/img/product_Img/AlderneyRosewood/alderney_3220_handcrafted_7mm_leather_396_last.png" }
                },
                new ProductModel
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Flore Black",
                    VendorCode = "411917",
                    Price = 17000,
                    SalePrice = 12000,
                    Style = "Оксфорд",
                    Shoe = 464,
                    Fullness = "G",
                    SoleMethod = "Рантовий",
                    Sole = "Шкіра",
                    Country = "Англія",
                    TopMaterial = "Натуральна шкіра",
                    Size = new List<double> { 9, 10, 11 },
                    Color = "BLACK",
                    IsAvailable = true,
                    IsOnSale = false,
                    Description = "Класичні оксфорди з перфорацією на носку. Комбінація гладкої та зернистої телячої шкіри. Будуть стильним доповненням вашого формального костюма.",
                    Img = new List<string> { "/img/product_Img/FloreBlack/flore_blackcalfgrain_angle_1.png", "/img/product_img/FloreBlack/flore_blackcalfgrain_side.png", "/img/product_img/FloreBlack/flore_blackcalf_top.png", "/img/product_img/FloreBlack/warrington_392737_last464_script-sole_3_2.png" }
                },
                new ProductModel
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Flore Black1",
                    VendorCode = "411918",
                    Price = 18000,
                    SalePrice = 11000,
                    Style = "Оксфорд",
                    Shoe = 464,
                    Fullness = "G",
                    SoleMethod = "Рантовий",
                    Sole = "Шкіра",
                    Country = "Англія",
                    TopMaterial = "Натуральна шкіра",
                    Size = new List<double> { 9, 10, 11 },
                    Color = "BLACK",
                    IsAvailable = true,
                    IsOnSale = false,
                    Description = "Класичні оксфорди з перфорацією на носку. Комбінація гладкої та зернистої телячої шкіри. Будуть стильним доповненням вашого формального костюма.",
                    Img = new List<string> { "/img/product_Img/FloreBlack/flore_blackcalfgrain_angle_1.png", "/img/product_img/FloreBlack/flore_blackcalfgrain_side.png", "/img/product_img/FloreBlack/flore_blackcalf_top.png", "/img/product_img/FloreBlack/warrington_392737_last464_script-sole_3_2.png" }
                }
                );
        }
    }
}
