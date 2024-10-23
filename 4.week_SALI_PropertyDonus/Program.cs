using System;

namespace _4.week_SALI_PropertyDonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calisan simitci = new Calisan();

            simitci.Ad = "Berkan";
            simitci.Yas = 24;

            simitci.KunyeYazdir();

            Calisan menager = new Calisan();
            menager.Ad = "Yaşar";
            menager.Yas = -23;

            menager.KunyeYazdir();



            Console.ReadKey();
        }
    }
}
