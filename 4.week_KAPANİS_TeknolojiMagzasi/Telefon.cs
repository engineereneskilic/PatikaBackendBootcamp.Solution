using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_KAPANİS_TeknolojiMagzasi
{
    public class Telefon : BaseMakine
    {

        public bool IsTurkishLicensed { get; set; }

        // Ürün Adını Getir metodu
        public override string GetProductName()
        {
            return $"Telefonunuzun adı ---> {Name}";
        }

        // BilgileriYazdir metodunu ezme işlemi
        public override void PrintInfo()
        {
            base.PrintInfo(); // Temel bilgileri yazdırır
            Console.WriteLine($"Türkiye Lisanslı mı?: {IsTurkishLicensed}");
        }
    }
}
