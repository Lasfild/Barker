using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Barker.Models
{
    public class CategoryModel
    {
        [Key]
        [Required]
        [DisplayName("Category Id")]
        public ushort Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public string? Name { get; set; }

        [Required]
        [DisplayName("Category Description")]
        public string? Description {  get; set; }

        [Required]
        [DisplayName("Category Img")]
        public string? Img { get; set; }

        public ICollection<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
