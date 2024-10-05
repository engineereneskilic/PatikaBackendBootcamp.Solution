using System;

namespace _2.week_3_PRATIK_while_S03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Başlangıç sayısı 2 olarak ayarlanıyor çünkü ilk çift sayı 2'dir
            int sayi = 2;

            // While döngüsü: sayı 20'den küçük veya eşit olduğu sürece döngü devam eder
            while (sayi <= 20)
            {
                // Sayıyı ekrana yazdır (sadece çift sayılar zaten bu aralıkta çalışıyor)
                Console.WriteLine(sayi);

                // Çift sayıları ekrana yazdırmak için her adımda 2 artırıyoruz
                sayi += 2;
            }

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
