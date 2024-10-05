using System;

namespace _2.week_3_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            while (sayac < 5) 
            {
                Console.WriteLine($"Sayı {sayac}");
                sayac++;
            }


            string girdi = string.Empty;

            Random rand = new Random();

            int hedef = rand.Next(1,10);
            int tahmin = 0;

            while (tahmin != hedef)
            {
                Console.WriteLine("Bir tahmin yapın");
                tahmin = int.Parse(Console.ReadLine());

                if(tahmin <  hedef)
                {
                    Console.WriteLine("Daha büyük bir sayı girmelesiniz");
                }
                else
                if(tahmin > hedef){
                    Console.WriteLine("daha hüçük bir sayı girin");
                }
                else
                {
                    Console.WriteLine("Tebrikler");
                }

                girdi = Console.ReadLine();

            }




            Console.ReadKey();
        }
    }
}
