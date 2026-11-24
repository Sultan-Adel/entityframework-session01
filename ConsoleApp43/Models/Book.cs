using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp43.Models
{
    [Table("Books_Inventory")]
    internal class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(13)]
        [Column("ISBN_Number")]
        public string ISBN { get; set; } = null!;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public int NumberOfPages { get; set; }
        public int PublishedYear { get; set; }
        public bool IsInStock { get; set; }

        // AuthorId
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        // CategoryId
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
