using System;

namespace _4.week_SALI_siralamaHarmonisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi[] kisiler = { 

                     new Kisi() { Ad = "", Yas = 2 },
                     new Kisi() { Ad = "", Yas = 2 },
                     new Kisi() { Ad = "", Yas = 2 },

            };

            foreach (Kisi k in kisiler)
            {
                Console.WriteLine(k.Ozet());
            }

            Console.ReadKey();
        }
    }
}
