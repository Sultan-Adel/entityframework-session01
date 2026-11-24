using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp43.Models
{
    [Table("Authors")]
    internal class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = null!;

        [MaxLength(500)]
        public string? Biography { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        // مش بتتخزن في الداتابيز
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
