using System.ComponentModel.DataAnnotations;

namespace _9.week_SALI_CRUD_Ornek.Models
{
    public class YeniOgrenciViewModel
    {
        [Display(Name = "Öğrencinin Adı")]
        [Required( ErrorMessage = "Bu alan zorunludur")]
        [MaxLength(20, ErrorMessage = "Öğrencinin adı 30 karakterden uzun olamaz")]
        public int Id { get; set; }

        [Display(Name = "Öğrencinin Adı")]
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string Ad { get; set; } = "";

        [Display(Name = "Tuttuğu Takım")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [MaxLength(20, ErrorMessage = "Takım adı 20 karakterden uzun olamaz")]
        public string Takim { get; set; } = "";


        [Display(Name = "Doğum Yılı")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        /*[Range(1900, )]*/
        public int? DogumYili { get; set; }


    }
}
