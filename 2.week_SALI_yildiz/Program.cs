using System;

namespace _2.week_SALI_yildiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(new string('*',a));
            }

            Console.ReadKey();
            Console.Clear();

            for (int a = 1; a < 10; a++)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.Write("*"); Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
