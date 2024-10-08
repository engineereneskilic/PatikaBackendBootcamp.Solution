using System;

namespace _2.week_8_valparams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 5;

            void DegeriDegistir(int y) // değer türü kopyalama olmuş
            {
                y = 10;
                
                Console.WriteLine($"Metot içindeki y değeri: {y}");
            }

            DegeriDegistir(y); // değer değiştirilmez

            Console.WriteLine($"Metot dışındaki y değeri: {y}");


            Console.WriteLine("###################################");

            int a = 5;
            void arttir(int a)
            {
                a++;
                Console.WriteLine($" Metot içindeki a değeri:{a}");
            }

            arttir(a);

            //a nın 6 olmaslı lazım ama olmaz
            Console.WriteLine($" Metot dışındaki a değeri:{a}");

            Console.ReadKey();

        }
    }
}
