using _7.week_SALI_DataLIB;
using System;
using System.Linq;

namespace _7.week_SALI_Sorgular6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** MESLEKLER ***");

            var meslekler = Veri.unluler.Select(x => x.Meslek).Distinct();

            foreach (string meslek in meslekler)
            {
                Console.WriteLine(meslek);
            }

            Console.WriteLine();
            Console.WriteLine("Meslek Çeşit Adedi: " + meslekler.Count());

            Console.ReadKey();
        }
    }
}
