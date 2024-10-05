using System;

namespace _2.week_3_PRATIK_while_S04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplamı saklayacak değişkeni 0 olarak başlatıyoruz
            int toplam = 0;

            // Başlangıç sayısı 50 olarak belirleniyor
            int sayi = 50;

            // While döngüsü: sayi 150'ye eşit veya küçük olduğu sürece döngü devam eder
            while (sayi <= 150)
            {
                // Her adımda mevcut sayıyı toplam değişkenine ekliyoruz
                toplam += sayi;

                // Sayıyı bir artırıyoruz, böylece bir sonraki sayıya geçiyoruz
                sayi++;
            }

            // Sonucu ekrana yazdırıyoruz
            Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
