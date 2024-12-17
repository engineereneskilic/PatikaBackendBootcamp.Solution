using System.ComponentModel.DataAnnotations.Schema;

namespace _12.week_Library_s02.Data.Entities
{
    public class BookDetail
    {
        public int Id { get; set; }
        public int BookId { get; set; }

        public string ISBN { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }


        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
    }
}
