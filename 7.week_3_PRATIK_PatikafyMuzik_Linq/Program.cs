
using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.week_3_PRATIK_PatikafyMuzik_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Updated artist data
            List<Sarkici> sarkicilar = new List<Sarkici>
        {
            new Sarkici { AdSoyad = "Ajda Pekkan", Tur = "Pop", CikisYili = 1968, AlbumSatis = 20 },
            new Sarkici { AdSoyad = "Sezen Aksu", Tur = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatis = 10 },
            new Sarkici { AdSoyad = "Funda Arar", Tur = "Pop", CikisYili = 1999, AlbumSatis = 3 },
            new Sarkici { AdSoyad = "Sertab Erener", Tur = "Pop", CikisYili = 1994, AlbumSatis = 5 },
            new Sarkici { AdSoyad = "Sıla", Tur = "Pop", CikisYili = 2009, AlbumSatis = 3 },
            new Sarkici { AdSoyad = "Serdar Ortaç", Tur = "Pop", CikisYili = 1994, AlbumSatis = 10 },
            new Sarkici { AdSoyad = "Tarkan", Tur = "Pop", CikisYili = 1992, AlbumSatis = 40 },
            new Sarkici { AdSoyad = "Hande Yener", Tur = "Pop", CikisYili = 1999, AlbumSatis = 7 },
            new Sarkici { AdSoyad = "Hadise", Tur = "Pop", CikisYili = 2005, AlbumSatis = 5 },
            new Sarkici { AdSoyad = "Gülben Ergen", Tur = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatis = 10 },
            new Sarkici { AdSoyad = "Neşet Ertaş", Tur = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatis = 2 }
        };

            // 1. Singers whose names start with 'S'
            var sIleBaslayan = sarkicilar.Where(s => s.AdSoyad.StartsWith("S")).ToList();
            Console.WriteLine("Singers whose names start with 'S':");
            foreach (var sarkici in sIleBaslayan)
            {
                Console.WriteLine($"- {sarkici.AdSoyad}");
            }

            // 2. Singers with album sales over 10 million
            var onMilyonUstu = sarkicilar.Where(s => s.AlbumSatis > 10).ToList();
            Console.WriteLine("\nSingers with album sales over 10 million:");
            foreach (var sarkici in onMilyonUstu)
            {
                Console.WriteLine($"- {sarkici.AdSoyad} ({sarkici.AlbumSatis} million)");
            }

            // 3. Singers who debuted before 2000 and perform pop music
            var eskiPop = sarkicilar
                .Where(s => s.CikisYili < 2000 && s.Tur.Contains("Pop"))
                .OrderBy(s => s.CikisYili)
                .ThenBy(s => s.AdSoyad)
                .ToList();
            Console.WriteLine("\nSingers who debuted before 2000 and perform pop music:");
            foreach (var sarkici in eskiPop)
            {
                Console.WriteLine($"- {sarkici.AdSoyad} (Debut Year: {sarkici.CikisYili})");
            }

            // 4. The singer with the highest album sales
            var enCokSatan = sarkicilar.OrderByDescending(s => s.AlbumSatis).FirstOrDefault();
            Console.WriteLine($"\nThe singer with the highest album sales: {enCokSatan.AdSoyad} ({enCokSatan.AlbumSatis} million)");

            // 5. The newest and oldest debuting singers
            var enYeni = sarkicilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
            var enEski = sarkicilar.OrderBy(s => s.CikisYili).FirstOrDefault();
            Console.WriteLine($"\nThe newest debuting singer: {enYeni.AdSoyad} (Debut Year: {enYeni.CikisYili})");
            Console.WriteLine($"The oldest debuting singer: {enEski.AdSoyad} (Debut Year: {enEski.CikisYili})");
        }
    }
}
