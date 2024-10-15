using System;

namespace _3.week_Sali_1_metodcesitleri
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

         

            void TekrarliYazdir(string metin, int kere)
            {
                for (int i = 0; i < kere; i++)
                {
                    Console.WriteLine("metin");
                }
            }

            TekrarliYazdir("Ankaranın Bağları",7);

            int ZarAt()
            {
                return new Random().Next(1,7);
            }

            int zar = ZarAt();
            Console.WriteLine($"Gelen Zar: {zar}");


            // Parametre almayan Değer Döndürmeyen
            void SaatiYazdir()
            {
                Console.WriteLine(DateTime.Now.ToLongDateString());
            }


            SaatiYazdir();

        }
    }
}
