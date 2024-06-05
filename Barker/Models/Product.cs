namespace Barker.Models
{
    public class Product
    {
        public ushort Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Sale { get; set; }
        public bool Availability { get; set; } 
        public ushort CategoryId { get; set; } 
        public virtual Category Category { get; set; } = new Category();
    }
}
