
using System;

namespace _3.week_SALI_3_AsalSayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool AsalMi(int sayi)
            {
                for (int i = 2; i <= Math.Sqrt(sayi); i++)
                {
                    if(sayi % i == 0)
                    {
                        return false;
                    }
                }
                return true;
                
            }

            Console.WriteLine("Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(AsalMi(sayi) ? "Asal" : "Asal Değil");

            Console.ReadKey();
        }
    }
}
