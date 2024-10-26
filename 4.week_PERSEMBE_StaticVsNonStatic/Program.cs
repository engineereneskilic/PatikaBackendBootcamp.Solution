using System;

namespace _4.week_PERSEMBE_StaticVsNonStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //herkes için vergi oranını tek satırda değiştirme    

            Calisan.VergiOraniniGuncelle(50);

            Calisan c1 = new Calisan("Enes","Backend Developer",17002M);
            Calisan c2 = new Calisan("İlayda","CEO",100000m);
            Calisan c3 = new Calisan("Hakan", "Backend Developer", 17002M);
            Calisan c4 = new Calisan("İlayda", "CEO", 100000m);


            Calisan[] calisanlar = { c1, c2, c3, c4 };

            foreach (var calisan in calisanlar)
            {
                Console.WriteLine(calisan.Ad);
            }


            Console.ReadKey();

        }
    }
}
