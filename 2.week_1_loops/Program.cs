using System;

namespace _2.week_1_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
            }

            for (int i = 10;i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            int[] sayilar = { 1, 2, 3, 4, 5, 6 };

            foreach (var item in sayilar)
            {

            }

            int sayi = 5;
            int faktoriyel = 1;

            for(int i = 1; i <= sayi;i++)
            {
                faktoriyel *= i;
            }

            Console.WriteLine($"Faktoriye:" + faktoriyel);




            Console.ReadKey();

        }
    }
}
