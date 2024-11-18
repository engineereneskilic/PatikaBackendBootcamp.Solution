using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.week_4_PRATIK_Patikaflix_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Verilerin statik tanımı
            List<Dizi> diziler = new List<Dizi>
            {
                new Dizi { Adi = "Avrupa Yakası", Yili = 2004, Tur = "Komedi", BaslamaYili = 2004, Yönetmen = "Yiğit Aksu", Platform = "Kanal D" },
                new Dizi { Adi = "Yalan Dünya", Yili = 2012, Tur = "Komedi", BaslamaYili = 2012, Yönetmen = "Gülseren Buda", Platform = "Fox TV" },
                new Dizi { Adi = "Jet Sosyete", Yili = 2018, Tur = "Komedi", BaslamaYili = 2018, Yönetmen = "Gülseren Buda", Platform = "Tv8" },
                new Dizi { Adi = "Dadı", Yili = 2006, Tur = "Komedi", BaslamaYili = 2006, Yönetmen = "Yusuf Pirhasan", Platform = "Kanal D" },
                new Dizi { Adi = "Belalı Baldız", Yili = 2007, Tur = "Komedi", BaslamaYili = 2007, Yönetmen = "Yiğit Aksu", Platform = "Kanal D" },
                new Dizi { Adi = "Arka Sokaklar", Yili = 2004, Tur = "Polisiye, Dram", BaslamaYili = 2004, Yönetmen = "Orhan Oğuz", Platform = "Kanal D" },
                new Dizi { Adi = "Aşk-ı Memnu", Yili = 2008, Tur = "Dram, Romantik", BaslamaYili = 2008, Yönetmen = "Hilal Saral", Platform = "Kanal D" },
                new Dizi { Adi = "Muhtesem Yüzyıl", Yili = 2011, Tur = "Tarihi, Dram", BaslamaYili = 2011, Yönetmen = "Mercan Çilingiroğlu", Platform = "Star TV" },
                new Dizi { Adi = "Yaprak Dökümü", Yili = 2006, Tur = "Dram", BaslamaYili = 2006, Yönetmen = "Serdar Akar", Platform = "Kanal D" },
            };

            // Komedi türündeki dizileri filtreleme
            List<YeniListe> komediDizileri = diziler
                .Where(d => d.Tur.Equals("Komedi", StringComparison.OrdinalIgnoreCase))
                .Select(d => new YeniListe
                {
                    Adi = d.Adi,
                    Tur = d.Tur,
                    Yönetmen = d.Yönetmen
                })
                .OrderBy(d => d.Adi)
                .ThenBy(d => d.Yönetmen)
                .ToList();

            // Komedi dizilerini ekrana yazdırma
            Console.WriteLine("\nKomedi Türündeki Diziler:");
            foreach (var komedi in komediDizileri)
            {
                Console.WriteLine($"Dizi Adı: {komedi.Adi}, Tür: {komedi.Tur}, Yönetmen: {komedi.Yönetmen}");
            }

        }
    }
}
