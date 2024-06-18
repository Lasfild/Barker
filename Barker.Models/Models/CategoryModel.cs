using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barker.Models
{
    public class CategoryModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        public string? Img { get; set; }

        [NotMapped]
        public IFormFile? ImgFile { get; set; }

        public List<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
