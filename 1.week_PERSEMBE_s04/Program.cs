using System;

namespace _1.week_PERSEMBE_s04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            soru:
            Console.Write("Bir sayı giriniz:");
            string cevap = Console.ReadLine();
            int sayi;
            bool basariliMi = int.TryParse(cevap, out sayi);

            if(!basariliMi)
            {
                Console.WriteLine("Geçersiz bir sayi girdiniz!");
                Console.WriteLine("Lütfen tekrar giriniz.");
                goto soru;
            }


        }
    }
}
