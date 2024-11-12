using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _7.week_SALI_DataLIB;

namespace _7.week_SALI_Sorgular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ülkeleri listele

            foreach (Ulke ulke in Veri.ulkeler)
            {
                Console.WriteLine(ulke.Id);
            }
            Console.WriteLine("###############################################################################");

            // 1970 öncesi doğan ünlüler
            //IEnumerable<Unlu> oncesi70 = Veri.unluler.Where(q => q.DogumYili < 1970);
            IEnumerable<Unlu> oncesi70 = Veri.unluler.Where(Olcut);

            foreach (var item in oncesi70)
            {
                Console.WriteLine(item.Ad + "(" + item.DogumYili + ")");
            }

            bool Olcut(Unlu unlu)
            {
                return unlu.DogumYili < 1970;
            }


            Console.WriteLine("###############################################################################");
            Console.WriteLine("A ismi ile başlayan ünlüler");
            var sonuc2 = Veri.unluler.Where(AdiAileBaslarMı);
            var sonuc3 = Veri.unluler.Where(u => u.Ad.StartsWith("A"));
            foreach (var unlu in sonuc2)
            {
                Console.WriteLine(unlu.Ad);
            }


            bool AdiAileBaslarMı(Unlu unlu)
            {
                return unlu.Ad.StartsWith("A");
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("1970 Sonrası doğan Oyuncu Ünlüler");

            foreach (var unlu in Veri.unluler.Where(x => x.DogumYili > 1970 && x.Meslek.Contains("Oyuncu"))
                                             .OrderBy(x => x.DogumYili)
                                             .ThenByDescending(x => x.Ad)
                                             )
            {

                Console.WriteLine(unlu.Ad + "(" + unlu.DogumYili + ")");
            }

            // Yukarıdaki sorguda aynı yılda doğanların isimlerine göre tersten sıralanmış olduğuna dikkat ediniz


            //JOIN



            Console.ReadKey();
        }
    }
}
