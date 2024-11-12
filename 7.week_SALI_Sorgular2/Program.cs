using _7.week_SALI_DataLIB;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace _7.week_SALI_Sorgular2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Ülkeleriyle Ünlüler ***");

            var sonuc = Veri.unluler.Join(
                 Veri.ulkeler,
                 unlu => unlu.UlkeId,
                 ulke => ulke.Id,
                 (unlu,ulke) => new { UnluAd = unlu.Ad,UlkeAd = ulke.Ad }
                );

            foreach (var oge in sonuc)
            {
                Console.WriteLine(oge.UnluAd +" - " +oge.UlkeAd);
            }

            Console.ReadKey();

        }
    }
}
