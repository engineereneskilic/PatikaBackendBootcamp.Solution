using System;

namespace _2.week_2_PRATIK_loops_S05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 50 ile 150 arasındaki sayıların toplamını tutmak için bir değişken tanımlıyoruz
            int toplam = 0;

            // 50'den başlayıp 150'ye kadar olan tüm sayıları döngü ile geziyoruz
            for (int i = 50; i <= 150; i++)
            {
                // Her bir sayıyı toplama ekliyoruz
                toplam += i;
            }

            // Toplam sonucu ekrana yazdırıyoruz
            Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
