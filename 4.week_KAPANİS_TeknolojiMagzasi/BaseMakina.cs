using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_KAPANİS_TeknolojiMagzasi
{
    // Temel sınıfımız: BaseMakine
    // Bu sınıf, Telefon ve Bilgisayar sınıfları için ortak olan özellikleri ve metotları içerir.
    public abstract class BaseMakine
    {
        // Üretim tarihi otomatik olarak atanır.
        public DateTime ProductionDate { get; private set; } = DateTime.Now;
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        // Ürün Adını Getir metodu - her sınıfta ayrı ezilecek (abstract)
        public abstract string GetProductName();

        // BilgileriYazdir metodu - Telefon ve Bilgisayar sınıflarında ezilecektir.
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Üretim Tarihi: {ProductionDate}");
            Console.WriteLine($"Seri Numarası: {SerialNumber}");
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Açıklama: {Description}");
            Console.WriteLine($"İşletim Sistemi: {OperatingSystem}");
        }
    }
    
}
