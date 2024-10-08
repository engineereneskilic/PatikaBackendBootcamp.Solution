using System;
using System.Reflection.Metadata;

namespace _2.week_10_out
{
    internal class Program
    {
       
        static void Main(string[] args)
        {


            void BolumveKalan(int bolunen, int bolen, out int bolum, out int kalan)
            {
                bolum = bolunen / bolen;
                kalan = bolunen % bolen;
            }

            int bölüm;
            int kalan;

            BolumveKalan(10, 3, out bölüm, out kalan);

            Console.WriteLine($"Bölüm {bölüm} Kalan {kalan}");

            Console.WriteLine($"Bölüm: {bölüm}");


            bool TryParseInt(string deger, out int sonuc)
            {
                return int.TryParse(deger, out sonuc);
            }

            int sonuc;

            bool basarilimi = TryParseInt("123", out sonuc);

            Console.WriteLine($"Donusturme oldu mu: {basarilimi}");

            Console.ReadKey();





        }
    }
}
