using System;

namespace _2.week_3_PRATIK_while_S02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Başlangıç sayısı 1 olarak ayarlanıyor
            int sayi = 1;

            // While döngüsü: sayı 20'den küçük veya eşit olduğu sürece döngü devam eder
            while (sayi <= 20)
            {
                // Sayıyı ekrana yazdır
                Console.WriteLine(sayi);

                // Sayıyı her döngüde 1 artırarak bir sonraki sayıya geçiyoruz
                sayi++;
            }

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
