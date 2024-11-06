using System;
using System.Collections.Generic;

namespace _5.week_5_PRATIK_DavetGecesi_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ziyaretçilerin isimlerini içeren listeyi tanımlıyoruz
            List<string> guestList = new List<string>
            {
                "Bülent Ersoy",
                "Ajda Pekkan",
                "Ebru Gündeş",
                "Hadise",
                "Hande Yener",
                "Tarkan",
                "Funda Arar",
                "Demet Akalın"
            };

            // Gala gecesi başlığı
            Console.WriteLine("Patika Plus Gala Gecesi Ziyaretçi Listesi:");

            // foreach döngüsü kullanarak liste içindeki isimleri ekrana yazdırıyoruz
            foreach (string guest in guestList)
            {
                Console.WriteLine("- " + guest); // Her bir ismi başına "-" ekleyerek yazdırıyoruz
            }

        }
    }
}
