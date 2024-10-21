
using System;

namespace _3.week_PERSEMBE_3_asalmii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool AsalMi(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if(n % i == 0)
                    {
                        return false;
                    }

                    
                }

                return true;
            }

            Console.WriteLine(AsalMi(13));


            for (int i = 1; i <= 100; i++)
            {
                if (AsalMi(i))
                {
                    Console.WriteLine("Bu sayı asaldır");
                }
            }

        }
    }
}
