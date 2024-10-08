
using System;

namespace _2.week_10_debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Add(i,i));
            }

            static int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
}
