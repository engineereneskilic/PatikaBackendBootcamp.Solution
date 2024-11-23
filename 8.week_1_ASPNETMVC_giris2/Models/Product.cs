using System.ComponentModel.DataAnnotations;

namespace _8.week_1_ASPNETMVC_giris2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı gereklidir")]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0, 100000)]
        public decimal Price { get; set; }
    }
}
