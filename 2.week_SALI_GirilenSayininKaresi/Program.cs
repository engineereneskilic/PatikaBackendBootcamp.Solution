
using System;

namespace _2.week_SALI_GirilenSayininKaresi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            bool kontrol;

            do
            {
                Console.Write("Sayı: ");
                kontrol = int.TryParse(Console.ReadLine(), out sayi);

            } while (!kontrol);

            Console.WriteLine("Karesi: "+ sayi * sayi);
            Console.ReadKey();
        }
    }
}
