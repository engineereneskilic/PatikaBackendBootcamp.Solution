
using System;

namespace _2.week_SALI_IterasyonAtlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-20 aralığında sayıları yazdır
            // 3ün ve 5kin katı olanları hari.

            #region Yöntem 1
            for (int i = 1; i <= 20; i++)
            {
               if(i % 3 !=0 && i % 5 != 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            #endregion

            #region Yöntem 1
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 != 0 || i % 5 != 0)
                    continue;

                Console.WriteLine();
            }
            #endregion

        }
    }
}
