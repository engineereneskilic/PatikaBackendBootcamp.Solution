using System;

namespace _3.week_PERSEMBE_2_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Topla(int sayi)
            {
               if(sayi == 0 || sayi == 1) 
                {
                    return sayi;
                }

                return sayi + Topla(sayi - 1);
            }
        }
    }
}
