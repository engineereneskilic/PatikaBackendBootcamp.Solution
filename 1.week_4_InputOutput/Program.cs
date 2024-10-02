using System;

namespace _1.week_4_InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Merhaba Dünya";

            Console.WriteLine(greeting);

            Console.Write("Lütfen isminizi yazınız:");
            string isim = Console.ReadLine();
        }
    }
}
