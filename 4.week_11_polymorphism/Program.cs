using System;
using System.Security.Cryptography.X509Certificates;

namespace _4.week_11_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kare nesnesi oluşturuluyor ve alanı hesaplanıyor
            Kare kare = new Kare();
            kare.Genişlik = 5;
            kare.Yükseklik = 5;
            Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}");

            // Dikdörtgen nesnesi oluşturuluyor ve alanı hesaplanıyor
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.Genişlik = 4;
            dikdörtgen.Yükseklik = 6;
            Console.WriteLine($"Dikdörtgen Alanı: {dikdörtgen.AlanHesapla()}");

            // DikUcgen nesnesi oluşturuluyor ve alanı hesaplanıyor
            DikUcgen dikUcgen = new DikUcgen();
            dikUcgen.Genişlik = 3;
            dikUcgen.Yükseklik = 4;
            Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen.AlanHesapla()}");

            // Programın sonlanmasını beklemek için bir tuşa basmayı bekliyoruz
            Console.ReadKey();
        }


        // BaseGeometrikSekil sınıfı: Ortak özellikleri içeren temel sınıf
        public abstract class BaseGeometrikSekil
        {
            // Genişlik ve Yükseklik property'leri tanımlanıyor
            public double Genişlik { get; set; }
            public double Yükseklik { get; set; }

            // AlanHesapla metodu: Bu metod base class'ta tanımlanıyor, ancak alt sınıflarda özelleştirilecek (override edilecek)
            public abstract double AlanHesapla();
        }

        // Kare sınıfı: BaseGeometrikSekil sınıfından türeyen sınıf
        public class Kare : BaseGeometrikSekil
        {
            // AlanHesapla metodu override edilerek Kare'ye özel hesaplama yapılıyor
            public override double AlanHesapla()
            {
                // Karenin alanı Genişlik * Yükseklik (Ancak karede genişlik ve yükseklik eşittir)
                return Genişlik * Yükseklik;
            }
        }

        // Dikdörtgen sınıfı: BaseGeometrikSekil sınıfından türeyen sınıf
        public class Dikdörtgen : BaseGeometrikSekil
        {
            // AlanHesapla metodu override edilerek Dikdörtgen'e özel hesaplama yapılıyor
            public override double AlanHesapla()
            {
                // Dikdörtgenin alanı Genişlik * Yükseklik
                return Genişlik * Yükseklik;
            }
        }

        // DikUcgen sınıfı: BaseGeometrikSekil sınıfından türeyen sınıf
        public class DikUcgen : BaseGeometrikSekil
        {
            // AlanHesapla metodu override edilerek Dik Üçgen'e özel hesaplama yapılıyor
            public override double AlanHesapla()
            {
                // Dik üçgenin alanı (Genişlik * Yükseklik) / 2
                return (Genişlik * Yükseklik) / 2;
            }
        }
    }
}
