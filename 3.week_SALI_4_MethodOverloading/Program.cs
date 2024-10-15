using System;

namespace _3.week_SALI_4_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {


            static double Karesi(double sayi)
            {
                return sayi * sayi;
            }


            static decimal Karesi(decimal sayi)
            {
                return sayi * sayi;
            }

        }
    }
}
