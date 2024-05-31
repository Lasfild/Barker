namespace Barker.Models
{
    public class Product
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription {  get; set; }
        public string Img { get; set; }
        public decimal Price { get; set; }
        public bool IsOnMain { get; set; }
        public bool Availability { get; set; } 
        public ushort CategoryId { get; set; } 
        public virtual Category Category { get; set; }
    }
}
