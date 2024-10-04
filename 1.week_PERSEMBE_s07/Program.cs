using System;

namespace _1.week_PERSEMBE_s07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya 0 ile 100 arasında bir not girmesi için mesaj yazdırıyoruz
            Console.WriteLine("Lütfen 0 ile 100 arasında bir not girin:");

            // Kullanıcının girdiği notu almak için bir değişken tanımlıyoruz
            // Console.ReadLine() kullanıcının girişini string olarak alır
            string kullaniciNotu = Console.ReadLine();

            // Girilen notu sayısal bir değere (int) çevirmemiz gerekiyor
            // Bu işlem için int.Parse() fonksiyonunu kullanıyoruz
            int not = int.Parse(kullaniciNotu);

            // Girilen notun geçerli olup olmadığını kontrol ediyoruz (0 ile 100 arasında olmalı)
            if (not >= 0 && not <= 100)
            {
                // Notun aralığını kontrol ediyoruz ve başarı durumunu belirliyoruz
                if (not <= 60)
                {
                    Console.WriteLine("Başarısız"); // Eğer not 0 ile 60 arasında ise "Başarısız" yazdırıyoruz
                }
                else if (not >= 61 && not <= 80)
                {
                    Console.WriteLine("Orta"); // Eğer not 61 ile 80 arasında ise "Orta" yazdırıyoruz
                }
                else if (not >= 81 && not <= 100)
                {
                    Console.WriteLine("Başarılı"); // Eğer not 81 ile 100 arasında ise "Başarılı" yazdırıyoruz
                }
            }
            else
            {
                // Eğer not 0 ile 100 arasında değilse geçersiz giriş olduğunu belirtiyoruz
                Console.WriteLine("Geçersiz not.");
            }

            // Program sonlanmadan önce kullanıcıdan bir tuşa basmasını bekliyoruz
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey(); // Konsolu kapatmadan önce kullanıcının bir tuşa basmasını bekliyoruz

        }
    }
}
