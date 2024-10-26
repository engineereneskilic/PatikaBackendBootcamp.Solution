using System;
using System.Runtime.Intrinsics.Arm;

namespace _4.week_PERSEMBE_abstract_sekillerdunyani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sekil s1 = new Dikdortgen { Genislik = 100, Yukseklik = 50 };
           
            Console.WriteLine(s1);

            Console.WriteLine("Alanı: "+ s1.Alan());
            Console.WriteLine("Çevre: "+ s1.Cevre());
            Console.WriteLine("Köşe adedi: " + ((Dikdortgen)s1).KoseAdedi.ToString());

            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
