using _11.week_GalacticTour_03.Attributes;
using System.ComponentModel.DataAnnotations;

namespace _11.week_GalacticTour_03.Models
{
    public class GalacticProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün Adı Gereklidir")]
        [StringLength(maximumLength:100,MinimumLength =3,ErrorMessage = "Ürün min 3 max 100 karakter olmalıdır !")]
        public string Name { get; set; }

        [Range(0.01,1000,ErrorMessage = "Fiyat 0.01 ile 1000 arasında olmalıdır")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Gezegen adı boş geçilemez")]
        [RegularExpression("^(Merkür | Venüs | Mars)$",ErrorMessage = "Geçerli bir gezegene ait ürün değil")]
        public string Planet { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Üretim Tarihi")]
        public DateTime ManifacturingDate { get; set; }

        [Range(1,10)]
        [Display(Name= "Reying")]
        public int GalacticRating { get; set; }

        [GalacticElementComposition(minElements:2,maxElement:5)]
        public string Composition { get; set; }


        public GalacticCordinate Cordinate { get; set; }

    }
}
