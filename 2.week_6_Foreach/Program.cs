using System;

namespace _2.week_6_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 8, 6, 7 };

            foreach (var item in sayilar)
            {
                Console.WriteLine($"Sayı {item }");
            }
        }
    }
}
