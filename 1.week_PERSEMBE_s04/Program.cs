using System;

namespace _1.week_PERSEMBE_s04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya bir tam sayı girmesi için mesaj yazdırıyoruz
            Console.WriteLine("Lütfen bir tam sayı girin:");

            // Kullanıcının girdiği tam sayı bilgisini almak için bir değişken tanımlıyoruz
            // Burada Console.ReadLine() kullanıcının girişini alır ve bunu bir string olarak döndürür
            string kullaniciSayisi = Console.ReadLine();

            // Girdiğimiz sayıyı sayısal bir değere (int) çevirmemiz gerekiyor
            // Bu işlem için int.Parse() kullanıyoruz. Eğer kullanıcı geçersiz bir değer girerse hata oluşabilir
            int sayi = int.Parse(kullaniciSayisi);

            // Girilen sayının çift mi yoksa tek mi olduğunu kontrol etmek için mod (%) operatörünü kullanıyoruz
            // Mod operatörü bir sayının 2'ye bölündüğünde kalanını verir
            if (sayi % 2 == 0) // Eğer sayı 2'ye tam bölünüyorsa, bu sayı çifttir
            {
                Console.WriteLine("Çift sayıdır.."); // Eğer sayı çift ise bu mesajı yazdırıyoruz
            }
            else // Sayı 2'ye bölünmüyorsa, bu sayı tektir
            {
                Console.WriteLine("Tek sayıdır.."); // Eğer sayı tek ise bu mesajı yazdırıyoruz
            }

            // Program sonlanmadan önce kullanıcıdan bir tuşa basmasını bekliyoruz
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey(); // Konsolu kapatmadan önce kullanıcının bir tuşa basmasını bekliyoruz
        }
    }
}
