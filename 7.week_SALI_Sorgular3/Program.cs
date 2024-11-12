
using _7.week_SALI_DataLIB;
using System;
using System.Linq;
using System.Security;

namespace _7.week_SALI_Sorgular3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** ÜNLÜLER ve ÜLKELERİ ****");

            var unluler = Veri.unluler;

            var ulkeler = Veri.ulkeler;

            var sonuc = unluler.Join(
                ulkeler,
                un => un.UlkeId,  // outer key  dışarıya giderkenki id
                ul => ul.Id,   // inner key   içeriye alırkenki id
                (unlu, ulke) => new UnluUlke()
                {
                    UnluId = unlu.Id,
                    UnluAd = unlu.Ad,
                    UnluDogumYili = unlu.DogumYili,
                    UlkeKod = ulke.Id,
                    UlkeAd = ulke.Ad

                }
            );
            foreach (var oge in sonuc)
            {
                Console.WriteLine(oge.UlkeKod + "  " + oge.UnluAd);
            }


            Console.ReadKey();
        }
    }
}
