using System;

namespace _2.week_2_PRATIK_loops_S04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 20 arasındaki sayılar içinde sadece çift sayıları yazdırmak için bir for döngüsü kullanıyoruz
            // Döngü 1'den başlayıp 20'ye kadar devam eder, ancak sadece çift sayıları ekrana yazdırır
            for (int i = 1; i <= 20; i++)
            {
                // Eğer sayı 2'ye tam bölünebiliyorsa bu sayıdır
                if (i % 2 == 0)
                {
                    // Çift sayıyı ekrana yazdırıyoruz
                    Console.WriteLine(i);
                }
            }

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
