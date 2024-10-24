using System;

namespace _4.week_10_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ogrenci nesnesi oluşturma ve özelliklerine değer atama
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ali";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.OgrenciNumarasi = 12345;

            // Ogretmen nesnesi oluşturma ve özelliklerine değer atama
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "Ayşe";
            ogretmen.Soyad = "Kara";
            ogretmen.Maas = 5000;

            // Öğrenci ve Öğretmen bilgilerini konsola yazdırma
            Console.WriteLine("Öğrenci Bilgileri:");
            ogrenci.OgrenciBilgileriYazdir();

            Console.WriteLine("\nÖğretmen Bilgileri:");
            ogretmen.OgretmenBilgileriYazdir();

            // Programın sonlanmasını engellemek için bir tuşa basılmasını bekleme
            Console.ReadKey();
        }

        // Base class: BaseKisi (Temel sınıf)
        public class BaseKisi
        {
            // Ad ve Soyad için property tanımları
            public string Ad { get; set; }
            public string Soyad { get; set; }

            // Ad ve Soyad'ı konsola yazdıran metot
            public void KisiBilgileriYazdir()
            {
                Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
            }
        }

        // Derived class: Ogrenci (Öğrenci sınıfı)
        public class Ogrenci : BaseKisi
        {
            // Öğrenci numarası için property
            public int OgrenciNumarasi { get; set; }

            // Öğrenci bilgilerini (Ad, Soyad ve Öğrenci Numarası) yazdıran metot
            public void OgrenciBilgileriYazdir()
            {
                // BaseKisi sınıfından gelen KisiBilgileriYazdir() metodunu çağırıyoruz
                KisiBilgileriYazdir();
                Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
            }
        }

        // Derived class: Ogretmen (Öğretmen sınıfı)
        public class Ogretmen : BaseKisi
        {
            // Maaş bilgisi için property
            public decimal Maas { get; set; }

            // Öğretmen bilgilerini (Ad, Soyad ve Maaş) yazdıran metot
            public void OgretmenBilgileriYazdir()
            {
                // BaseKisi sınıfından gelen KisiBilgileriYazdir() metodunu çağırıyoruz
                KisiBilgileriYazdir();
                Console.WriteLine($"Maaş: {Maas} TL");
            }
        }


    }
}
