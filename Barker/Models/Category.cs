namespace Barker.Models
{
    public class Category
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
