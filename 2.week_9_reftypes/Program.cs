using System;
using System.Threading.Channels;

namespace _2.week_9_reftypes
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            void IsimDegistir(kisi kisi)
            {
                kisi.Isim = "Ali";
            }

            //###############################
            void DiziDegistir(int[] dizi)
            {
                dizi[0] = 99;
            }



            kisi kisi = new kisi { Isim = "Mehmet", Yas = 21 };
           // Console.WriteLine($"Mevcut isim {kisi.Isim}");

           // IsimDegistir(kisi);

           // Console.WriteLine($"Sonra {kisi.Isim}");


            int[] sayilar = { 0, 1, 2, 3 };
            DiziDegistir(sayilar);

            Console.WriteLine($"Metotan sonra {sayilar[0]}");

            // Referans tipler doğrudan bulundukları yeri kullandıkları için herhangi bir yerde kullanıldıklarında doğrudan ilgili konumuna bağlı değişir

            Console.ReadKey();
        }


    }
}
