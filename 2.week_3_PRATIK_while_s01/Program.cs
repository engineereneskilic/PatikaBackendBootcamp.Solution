using System;

namespace _2.week_3_PRATIK_while_s01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mesajı kaç kez yazdıracağımızı belirleyen sayaç değişkeni
            int sayac = 1;

            // While döngüsü koşulu: sayaç 10'dan küçük veya eşit olduğu sürece döngü devam eder
            while (sayac <= 10)
            {
                // Mesajı ekrana yazdır
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");

                // Sayaç değerini her seferinde 1 artırarak döngünün sonunda sayaç 10 olduğunda döngünün sona ermesini sağla
                sayac++;
            }

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
