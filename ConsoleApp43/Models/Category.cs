using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp43.Models
{
    [Table("Categories")]
    internal class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(300)]
        public string? Description { get; set; }

        public bool IsActive { get; set; }
    }
}
