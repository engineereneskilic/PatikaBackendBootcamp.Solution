using System;

namespace _1.week_PERSEMBE_s05_sicaklik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hava Sıcaklığı: ");
            int sicaklik = Convert.ToInt32(Console.ReadLine());

            #region kisa hali
            if (sicaklik < 0)
            {
                Console.WriteLine("Donuyor");
            }
            else

                   if (sicaklik <= 30)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Sıcaklık");
            }
            #endregion
            #region Uzun hali
            if (sicaklik < 0)
            {
                Console.WriteLine("Donuyor");
            }
            else
            {
                if (sicaklik <= 30)
                {
                    Console.WriteLine("Normal");
                }
                else
                {
                    Console.WriteLine("Sıcaklık");
                }
            } 
            #endregion

        }
    }
}
