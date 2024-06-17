using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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

        [Required]
        public string? Img { get; set; }
    }
}
