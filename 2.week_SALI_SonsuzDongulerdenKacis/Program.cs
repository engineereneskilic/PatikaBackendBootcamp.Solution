
using System;

namespace _2.week_SALI_SonsuzDongulerdenKacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sürekli Çift Zar at
            // 6-6 Gelirse çık
            Random rnd = new Random();
            int a, b;

            while(true) 
            {
                a = rnd.Next(1, 7);
                b = rnd.Next(1, 7);
                Console.WriteLine("{0}-{1}",a,b);

                if (a == 6 && b == 6)
                    break;

            }

            Console.ReadKey();
        }
    }
}
