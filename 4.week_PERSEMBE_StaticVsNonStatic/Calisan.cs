using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_PERSEMBE_StaticVsNonStatic
{
    public class Calisan
    {

        public static decimal vergiOran = 0.15m;

        public string Ad { get; set; }

        public string Pozisyon { get; set; }

        public decimal NetMaas { get; set; }

        public Calisan()
        {
            
        }

        public Calisan(string ad, string pozisyon, decimal netMaas)
        {
            Ad = ad;
            Pozisyon = pozisyon;
            NetMaas = netMaas;
        }

        public decimal BrutMaas
        {
            get
            {
                return NetMaas + NetMaas * vergiOran;
            }
        }

        public static void VergiOraniniGuncelle(decimal yeniOran)
        {
            vergiOran = 50;
        }


    }
}
