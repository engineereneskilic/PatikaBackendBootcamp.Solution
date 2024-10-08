using System;

namespace _2.week_SALI_kavusansayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *   KUllanıcı iki sayı girecek 10 20 gibi
             *   Bu sayılar birbiirine kavuşsun
             * 
             * */
            /*
                        10   20 
                        11   19    
                        12    18
                        13     17

                        15    15
             
             */

            Console.Write("Yükselecek sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Düşecek sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi1,j = sayi2; i <= j; i++, j--)
            {
                Console.WriteLine($"{i} {j}");
            }

            Console.ReadKey();

        }
    }
}
