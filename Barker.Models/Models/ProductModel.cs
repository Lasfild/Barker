using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barker.Models
{
    public class ProductModel
    {
        [Key]
        [Required]
        public ushort Id { get; set; }

        [ForeignKey("Category")]
        public ushort CategoryId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public List<string>? Img { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int VendorCode { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public bool IsOnSale { get; set; }

        [Required]
        public string? Style { get; set; }

        [Required]
        public int Shoe { get; set; }

        [Required]
        public string? Fullness { get; set; }

        [Required]
        public string? SoleMethod { get; set; }

        [Required]
        public string? Sole { get; set; }

        [Required]
        public string? Country { get; set; }

        [Required]
        public string? TopMaterial { get; set; }

        [Required]
        public List<double>? Size { get; set; }

        [Required]
        public string? Color { get; set; }

        public CategoryModel? Category { get; set; }
    }
}