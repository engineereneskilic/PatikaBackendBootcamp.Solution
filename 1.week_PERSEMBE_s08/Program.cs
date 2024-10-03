using System;

namespace _1.week_PERSEMBE_s08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ay no: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            int adet;

            switch (ay)
            {
                case 2:
                    adet = 28;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    adet = 31;
                    break;
                default:
                    Console.WriteLine("Geçersiz bir ay numarası girdiniz !");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("Gün adeti: " + adet);
            Console.ReadKey();
        }
    }
}
