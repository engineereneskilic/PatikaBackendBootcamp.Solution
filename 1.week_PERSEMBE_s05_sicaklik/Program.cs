using System;

namespace _1.week_PERSEMBE_s05_sicaklik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya sıcaklık değerini Celsius cinsinden girmesi için mesaj yazdırıyoruz
            Console.WriteLine("Lütfen Celsius cinsinden sıcaklık değerini girin:");

            // Kullanıcının girdiği sıcaklık değerini almak için bir değişken tanımlıyoruz
            // Console.ReadLine() fonksiyonu, kullanıcının girişini string olarak alır
            string kullaniciSicakligi = Console.ReadLine();

            // Alınan sıcaklık değerini string'ten sayısal bir değere (int) çevirmemiz gerekiyor
            // Bu işlem için int.Parse() fonksiyonunu kullanıyoruz
            int sicaklik = int.Parse(kullaniciSicakligi);

            // Girilen sıcaklık değerini kontrol ediyoruz
            // Eğer sıcaklık 0'dan küçükse "Donuyor" mesajını yazdırıyoruz
            if (sicaklik < 0)
            {
                Console.WriteLine("Donuyor."); // Eğer sıcaklık 0'dan düşükse bu mesajı yazdırıyoruz
            }
            // Sıcaklık 0 ile 30 arasında ise "Normal" mesajını yazdırıyoruz
            else if (sicaklik >= 0 && sicaklik <= 30)
            {
                Console.WriteLine("Normal."); // Eğer sıcaklık 0 ile 30 arasında ise bu mesajı yazdırıyoruz
            }
            // Sıcaklık 30'dan büyükse "Sıcak" mesajını yazdırıyoruz
            else
            {
                Console.WriteLine("Sıcak."); // Eğer sıcaklık 30'dan yüksekse bu mesajı yazdırıyoruz
            }

            // Program sonlanmadan önce kullanıcıdan bir tuşa basmasını bekliyoruz
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey(); // Konsolu kapatmadan önce kullanıcının bir tuşa basmasını bekliyoruz
        }
    }
}
