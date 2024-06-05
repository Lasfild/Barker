using Barker.Models;

namespace Barker
{
    public class DBObjects
    {
        private static Dictionary<string, Category> Category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (Category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "Anniversary", Description = "Description 1" },
                        new Category { Name = "Categoryname2", Description = "Description 2" },
                        new Category { Name = "Categoryname3", Description = "Description 3" },
                        new Category { Name = "Categoryname4", Description = "Description 4" }
                    };

                    Category = new Dictionary<string, Category>();
                    foreach(Category element in list)
                    {
                        Category.Add(element.Name, element);
                    }
                }
                return Category;
            }
        }

        public static void Initial(AppDBContent content)
        {
            if (!content.Categories.Any())
                content.Categories.AddRange(Categories.Select(c => c.Value));

            if (!content.Products.Any())
                content.AddRange
                    (
                    new Product
                    {
                        Name = "ALDERNEY-ROSEWOOD",
                        Description = "Бездоганні оксфорди із одного цільного шматка шкіри, ручна робота, Goodyear welted, дизайн та виробництво - Англія. Ювілейна колекція. В наявності і в чорному кольорі.",
                        Price = 21400,
                        Sale = true,
                        Img = "/img/alderney_322026_rosewoodcalf.png",
                        Availability = true,
                        Category = Categories["Anniversary"]
                    },

                    new Product
                    {
                        Name = "Product2",
                        Description = "Description2",
                        Price = 25000,
                        Sale = false,
                        Img = "https://img.freepik.com/free-psd/cosmetic-bottle-container-isolated_23-2151352942.jpg?size=626&ext=jpg",
                        Availability = false,
                        Category = Categories["Categoryname2"]
                    },

                    new Product
                    {
                        Name = "Product3",
                        Description = "Description3",
                        Price = 35000,
                        Sale = false,
                        Img = "https://img.freepik.com/free-psd/body-wash-bottle-isolated-transparent-background_191095-25909.jpg?size=626&ext=jpg",
                        Availability = true,
                        Category = Categories["Categoryname3"]
                    },

                    new Product
                    {
                        Name = "Product4",
                        Description = "Description4",
                        Price = 45000,
                        Sale = true,
                        Img = "https://img.freepik.com/free-psd/skin-product-isolated_23-2151353672.jpg?size=626&ext=jpg",
                        Availability = true,
                        Category = Categories["Categoryname4"]
                    }
                    );
            content.SaveChanges();
        }
    }
}
