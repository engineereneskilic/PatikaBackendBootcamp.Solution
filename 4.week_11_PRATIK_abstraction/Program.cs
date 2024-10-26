using System;

namespace _4.week_11_PRATIK_abstraction
{
    internal class Program
    {

        // Çalışanların ortak özelliklerini tanımlamak için abstract bir sınıf oluşturuyoruz
        public abstract class Calisan
        {
            // Çalışanın adı, soyadı ve departman bilgilerini içeren özellikler
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Departman { get; set; }

            // Çalışanın görevini tanımlamak için abstract bir metod
            // Bu metodu her alt sınıf kendi görevine göre yeniden tanımlayacak
            public abstract void Gorev();
        }

        // Yazılım Geliştirici sınıfı, Calisan sınıfından türetilmiş
        public class YazilimGelistirici : Calisan
        {
            // Yazılım Geliştiricinin görevini konsola yazdıracak metod
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad} yazılım geliştirici olarak çalışıyorum.");
            }
        }

        // Proje Yöneticisi sınıfı, Calisan sınıfından türetilmiş
        public class ProjeYoneticisi : Calisan
        {
            // Proje Yöneticisinin görevini konsola yazdıracak metod
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad} proje yöneticisi olarak çalışıyorum.");
            }
        }

        // Satış Temsilcisi sınıfı, Calisan sınıfından türetilmiş
        public class SatisTemsilcisi : Calisan
        {
            // Satış Temsilcisinin görevini konsola yazdıracak metod
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad} satış temsilcisi olarak çalışıyorum.");
            }
        }

        static void Main(string[] args)
        {
            // Proje Yöneticisi nesnesi oluşturuluyor
            ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi
            {
                Ad = "Hasan",
                Soyad = "Çıldırmış",
                Departman = "Proje Yönetimi"
            };

            // Yazılım Geliştirici nesnesi oluşturuluyor
            YazilimGelistirici yazilimci = new YazilimGelistirici
            {
                Ad = "Enes",
                Soyad = "Kılıç",
                Departman = "Yazılım Geliştirme"
            };

            // Satış Temsilcisi nesnesi oluşturuluyor
            SatisTemsilcisi satisci = new SatisTemsilcisi
            {
                Ad = "Mehmet",
                Soyad = "Ak",
                Departman = "Satış"
            };

            // Görev metodlarını çağırarak her çalışanın görevini yazdırıyoruz
            projeYoneticisi.Gorev();
            yazilimci.Gorev();
            satisci.Gorev();

            Console.ReadKey();
        }

    }
}
