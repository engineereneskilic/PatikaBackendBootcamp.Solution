
using _7.week_SALI_DataLIB;
using System;
using System.Linq;

namespace _7.week_SALI_Sorgular4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            var sonuc = Veri.unluler.GroupBy(u => u.UlkeId);

            Console.WriteLine("TOPLAM GRUP ADEDİ:" + sonuc.Count());
            Console.WriteLine();


            foreach (var grup in sonuc)
            {
                Console.WriteLine(grup.Key + " Grubu - Adet ( "+ grup.Count() +" )");
                Console.WriteLine();


                foreach (var unlu in grup)
                {
                    Console.WriteLine(unlu.Ad + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
