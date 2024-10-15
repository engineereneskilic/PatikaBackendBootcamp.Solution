using System;

namespace _3.week_SALI_8_SonucaGulucukEkle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Buyut(ref string ad)
            {
                ad = ad.ToUpper();
            }

            string isim = "hamit";
            Buyut(ref isim);
            Console.WriteLine(isim);

            Console.ReadKey();
        }
    }
}
