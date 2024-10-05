using System;

namespace _2.week_2_PRATIK_loops_S02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 20 arasındaki sayıları yazdırmak için bir for döngüsü kullanıyoruz
            // Döngü 1'den başlayıp 20'ye kadar devam eder (her bir sayıyı tek tek yazdırır)
            for (int i = 1; i <= 20; i++)
            {
                // Mevcut sayıyı ekrana yazdırıyoruz
                Console.WriteLine(i);
            }

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
