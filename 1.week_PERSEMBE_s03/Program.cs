using System;

namespace _1.week_PERSEMBE_s03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya yaşını sormak için bir mesaj yazdırıyoruz
            Console.WriteLine("Lütfen yaşınızı girin:");

            // Kullanıcının girdiği yaş bilgisini almak için bir değişken tanımlıyoruz
            // Burada Console.ReadLine() kullanıcının girişini alır ve bunu bir string olarak döndürür
            string kullaniciYasi = Console.ReadLine();

            // Yaş bilgisini string'ten sayısal bir değere (int) çevirmemiz gerekiyor
            // Bunun için int.Parse() kullanıyoruz. Kullanıcı yanlış bir değer girerse hata oluşabilir
            // Bu yüzden yaşın bir sayı olduğundan emin olunması gerekir
            int yas = int.Parse(kullaniciYasi);

            // Kullanıcının yaşını kontrol ediyoruz
            // Eğer yaş 18 veya daha büyükse, kullanıcıya "Yetişkinsiniz" mesajı gösteriyoruz
            if (yas >= 18)
            {
                Console.WriteLine("Yetişkinsiniz."); // Kullanıcı yetişkinse bu mesajı gösteriyoruz
            }
            else
            {
                // Eğer yaş 18'den küçükse, kullanıcıya "Çocuksunuz" mesajı gösteriyoruz
                Console.WriteLine("Çocuksunuz."); // Kullanıcı çocuksa bu mesajı gösteriyoruz
            }

            // Programın sonuna geldik, çıkış yapmadan önce bir tuşa basılmasını bekliyoruz
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey(); // Konsolu kapatmadan önce kullanıcının bir tuşa basmasını bekler
        }
    }
}
