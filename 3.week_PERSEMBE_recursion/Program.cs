using System;

namespace _3.week_PERSEMBE_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0! = 1
            // 1! = 1
            // ......
            // 5! = 1 * 2 *3 * 4 5

            // 5! = 4! * 5


            // bu metod n! 'i hesaplanır
            #region RecursiveIle
            int FaktRec(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }

                return n * FaktRec(n - 1);
            } 
            #endregion


            #region RecursionKullanmadan
            int Fak1(int n)
            {
                int sonuc = 1;

                if (n == 0 || n == 1)
                {
                    return 1;
                }

                for (int i = 2; i <= n; i++)
                {
                    sonuc *= i; // sonuc = sonuc * i    
                }

                return sonuc;
            }

            Console.WriteLine($"5! =  {Fak1(5)}"); 
            #endregion

            Console.ReadKey();

        }
    }
}
