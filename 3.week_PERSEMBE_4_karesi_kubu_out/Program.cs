
using System;

namespace _3.week_PERSEMBE_4_karesi_kubu_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void KaresiKubunuHesapla(int sayi, out int karesi, out int kubu)
            {
                karesi = sayi * sayi;
                kubu = sayi * sayi * sayi;
            }

            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int kar, kup;
            KaresiKubunuHesapla(n, out kar, out kup);


            Console.WriteLine("Karesi: "+kar);
            Console.WriteLine("Kübü: "+kup);

            Console.ReadKey();
        }
    }
}
