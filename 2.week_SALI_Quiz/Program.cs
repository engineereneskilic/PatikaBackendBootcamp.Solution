using System;

namespace _2.week_SALI_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Türkiyenin başkenti neresidir?");

            Console.WriteLine("Cevap: ");
            string cevap = Console.ReadLine();

            while(cevap.ToLower() != "ankara")
            {
                Console.WriteLine("Yanlış cevap! Tekrar deneyiniz.");


                Console.WriteLine("Cevap: ");
                cevap = Console.ReadLine();
            }

            Console.WriteLine("Tekbrikler! Doğru Cevap :)");

        }
    }
}
