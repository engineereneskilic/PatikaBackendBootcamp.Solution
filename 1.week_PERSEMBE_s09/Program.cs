using System;

namespace _1.week_PERSEMBE_s09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan şifreyi girmesini istiyoruz
            Console.WriteLine("Lütfen şifrenizi girin:");

            // Kullanıcının girdiği şifreyi string olarak okuyoruz
            string sifre = Console.ReadLine();

            // Girilen şifreyi kontrol ediyoruz
            if (sifre == "12345") // Şifre doğruysa
            {
                // "Giriş Başarılı" mesajı yazdırıyoruz
                Console.WriteLine("Giriş Başarılı");
            }
            else // Şifre yanlışsa
            {
                // "Giriş Başarısız" mesajı yazdırıyoruz
                Console.WriteLine("Giriş Başarısız");
            }

            // Program sonlanmadan önce bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
