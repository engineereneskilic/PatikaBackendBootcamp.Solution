using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_6_PRATIK_Constructors_Bebek
{
    public class Bebek
    {
        // Bebek sınıfının property'leri: Ad, Soyad, Doğum Tarihi
        public string _ad { get; set; }
        public string _soyad { get; set; }
        public DateTime _dogumTarihi { get; set; }

        // Default constructor (parametre almayan)
        public Bebek()
        {
            // Her bebek oluşturulduğunda doğum tarihini o anın tarihi olarak atıyoruz
            _dogumTarihi = DateTime.Now;
            // Konsola bebek doğduğunda bir "Ingaaaa" sesi yazdırıyoruz
            Console.WriteLine("Ingaaaa! Bebek doğdu.");

            // Ad ve soyad için varsayılan değerler
            _ad = "Bilinmiyor";
            _soyad = "Bilinmiyor";
        }

        // Alternatif constructor (Ad ve Soyad parametreleri ile)
        public Bebek(string ad, string soyad)
        {
            // Parametre olarak gelen ad ve soyad değerlerini property'lere atıyoruz
            _ad = ad;
            _soyad = soyad;

            // Doğum tarihini yine o anın tarihi olarak atıyoruz
            _dogumTarihi = DateTime.Now;

            // Yine konsola "Ingaaaa" sesi yazdırıyoruz
            Console.WriteLine("Ingaaaa! Bebek doğdu.");
        }
    }
}
