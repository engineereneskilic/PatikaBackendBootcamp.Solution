using System;

namespace _2.week_3_PRATIK_while_S05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tek ve çift sayıların toplamını saklayacak değişkenleri başlatıyoruz
            int tekToplam = 0;   // Tek sayıların toplamı için
            int ciftToplam = 0;  // Çift sayıların toplamı için

            // Sayıyı 1'den başlatıyoruz
            int sayi = 1;

            // While döngüsü: sayi 120'ye eşit veya küçük olduğu sürece döngü devam eder
            while (sayi <= 120)
            {
                // Sayının çift olup olmadığını kontrol ediyoruz
                if (sayi % 2 == 0) // Eğer sayının 2'ye bölümünden kalan 0 ise
                {
                    ciftToplam += sayi; // Sayıyı çift toplamına ekliyoruz
                }
                else // Eğer sayı tek ise
                {
                    tekToplam += sayi; // Sayıyı tek toplamına ekliyoruz
                }

                // Sayıyı bir artırıyoruz, böylece bir sonraki sayıya geçiyoruz
                sayi++;
            }

            // Sonuçları ekrana yazdırıyoruz
            Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
