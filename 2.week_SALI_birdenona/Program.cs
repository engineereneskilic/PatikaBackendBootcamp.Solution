using System;

namespace _2.week_SALI_birdenona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

        baslangic:
            Console.WriteLine(a++);

            if (a <= 10)
                goto baslangic;
        }
    }
}
