using System;

namespace _2.week_4_PRATIK_dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan limit değeri alınır
            Console.Write("Bir limit değeri girin: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            // While döngüsü ile sayaç artırarak ekrana yazdırma işlemi
            Console.WriteLine("\nWhile Döngüsü Sonucu:");
            int sayac = 0; // Sayaç 0'dan başlar

            // Koşul: sayaç limit değerine ulaşana kadar devam eder
            while (sayac <= limit)
            {
                Console.WriteLine("Ben bir Patika'lıyım, sayaç: " + sayac);
                sayac++; // Sayaç her döngüde 1 artırılır
            }

            // Do-While döngüsü ile sayaç artırarak ekrana yazdırma işlemi
            Console.WriteLine("\nDo-While Döngüsü Sonucu:");
            sayac = 0; // Sayaç yeniden 0 olarak ayarlanır

            // Do-While döngüsü koşul kontrolünden önce en az bir kere çalışır
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım, sayaç: " + sayac);
                sayac++; // Sayaç her döngüde 1 artırılır
            } while (sayac <= limit); // Koşul: sayaç limit değerine ulaşana kadar devam eder

            /*
             * While ve Do-While Farkı:
             * 1. While döngüsünde koşul her şeyden önce kontrol edilir, eğer koşul baştan sağlanmazsa döngü hiç çalışmaz.
             * 2. Do-While döngüsünde ise koşul en son kontrol edilir, bu yüzden en az bir kez çalışır. 
             * Örneğin, limit -5 gibi negatif bir değer girildiğinde:
             *    - While döngüsü koşul sağlanmadığı için hiç çalışmaz.
             *    - Do-While döngüsü ise en az bir kez çalışır ve sayaç artırılmadan önce ekrana bir çıktı verir.
             */
        }
    }
}
