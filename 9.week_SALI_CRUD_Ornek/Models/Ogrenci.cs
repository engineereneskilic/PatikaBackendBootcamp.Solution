using System.ComponentModel.DataAnnotations;

namespace _9.week_SALI_CRUD_Ornek.Models
{
    public class Ogrenci
    {
        
        public int Id { get; set; }

        [Display(Name = "Öğrencinin Adı")]
        [Required(ErrorMessage = "Ad alanı zorunludur.")]

        public string? Ad { get; set; } = "";

        public string Takim { get; set; } = "";

        public int? DogumYili { get; set; }
    }
}
