using System;

namespace _1.week_6_ControlStructuresAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int number2 = -5;

            if(number2>0)
            {
                Console.WriteLine("Bu sayı pozitif");
            } else
            {
                Console.WriteLine("Bu sayı negatiftir");
            }

            if(number > 0)
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine("Sayı çifttir");
                }
                else
                {
                    Console.WriteLine("Sayı çifttir");
                }
            }

            int kullaniciYasi = 20;
            
            if(kullaniciYasi >= 18)
            {
                Console.WriteLine("Kullanıcı yetişkindir");
            }
            else
            {
                Console.WriteLine("kullanıcı reşit değildir");
            }

        }
    }
}
