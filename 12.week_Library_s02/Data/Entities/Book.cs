using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _12.week_Library_s02.Data.Entities
{
    [Table("Books")]
    [Microsoft.EntityFrameworkCore.Index(nameof(Author),IsUnique = true)]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }


        public int PublicationYear { get; set; }


        [Column("BookPrice", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        [Column("LastBorrowed")]
        public DateTime? LastBorrowedDate { get; set; }



        public List<Review> Reviews { get; set; }

    }
}
