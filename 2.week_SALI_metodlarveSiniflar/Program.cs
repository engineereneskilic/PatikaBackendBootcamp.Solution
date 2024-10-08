using System;

namespace _2.week_SALI_metodlarveSiniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zar atmak için bir tuşa basınız...");
            Console.ReadKey(true);

            Random rnd = new Random();
            int zar = rnd.Next(1,7);


            Console.WriteLine("\r\n yalandan bir zar: "+zar);

            Console.WriteLine("\r\n Tekrar için");

            Console.ReadKey();
        }
    }
}
