using System;

namespace _2.week_2_PRATIK_loops_S06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tek sayıların toplamını tutmak için bir değişken
            int tekToplam = 0;

            // Çift sayıların toplamını tutmak için bir değişken
            int ciftToplam = 0;

            // 1 ile 120 arasındaki tüm sayıları döngü ile geziyoruz
            for (int i = 1; i <= 120; i++)
            {
                // Eğer sayı 2'ye tam bölünüyorsa, bu sayıyı çift toplamına ekliyoruz
                if (i % 2 == 0)
                {
                    ciftToplam += i;  // Çift sayı toplamı
                }
                else
                {
                    // Eğer sayı 2'ye tam bölünmüyorsa, bu sayıyı tek toplamına ekliyoruz
                    tekToplam += i;   // Tek sayı toplamı
                }
            }

            // Tek sayıların toplamını ekrana yazdırıyoruz
            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);

            // Çift sayıların toplamını ekrana yazdırıyoruz
            Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
