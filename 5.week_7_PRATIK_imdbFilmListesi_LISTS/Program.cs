using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.week_7_PRATIK_imdbFilmListesi_LISTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Film nesnelerini depolamak için liste oluşturuyoruz.
            List<Film> filmListesi = new List<Film>();

            while (true)
            {
                // Kullanıcıdan film ismini alıyoruz.
                Console.Write("Film adı giriniz: ");
                string filmAdi = Console.ReadLine();

                // Kullanıcıdan IMDb puanını alıyoruz ve double'a dönüştürüyoruz.
                Console.Write("IMDb puanını giriniz (0.0 - 10.0 arası): ");
                double imdbPuani;
                while (!double.TryParse(Console.ReadLine(), out imdbPuani) || imdbPuani < 0 || imdbPuani > 10)
                {
                    Console.WriteLine("Geçerli bir IMDb puanı giriniz (0.0 - 10.0 arası): ");
                }

                // Film nesnesini oluşturup listeye ekliyoruz.
                filmListesi.Add(new Film(filmAdi, imdbPuani));

                // Kullanıcıya yeni bir film eklemek isteyip istemediğini soruyoruz.
                Console.Write("Yeni bir film eklemek ister misiniz? (E/H): ");
                string devam = Console.ReadLine().ToUpper();
                if (devam != "E")
                {
                    break; // Eğer kullanıcı "E" dışında bir şey girerse döngü sonlanır.
                }
            }

            // Tüm filmleri listeliyoruz.
            Console.WriteLine("\nTüm Filmler:");
            foreach (var film in filmListesi)
            {
                Console.WriteLine($"Film Adı: {film.Name}, IMDb Puanı: {film.ImdbRating}");
            }

            // IMDb puanı 4 ile 9 arasında olan filmleri listeliyoruz.
            Console.WriteLine("\nIMDb puanı 4 ile 9 arasında olan Filmler:");
            var filtrelenmisFilmler = filmListesi.Where(f => f.ImdbRating >= 4 && f.ImdbRating <= 9).ToList();
            foreach (var film in filtrelenmisFilmler)
            {
                Console.WriteLine($"Film Adı: {film.Name}, IMDb Puanı: {film.ImdbRating}");
            }

            // İsmi 'A' ile başlayan filmleri listeliyoruz.
            Console.WriteLine("\n'A' harfi ile başlayan Filmler:");
            var aIleBaslayanFilmler = filmListesi.Where(f => f.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var film in aIleBaslayanFilmler)
            {
                Console.WriteLine($"Film Adı: {film.Name}, IMDb Puanı: {film.ImdbRating}");
            }

            // Program sonlanmadan önce kullanıcının devam edebilmesi için bir mesaj gösteriyoruz.
            Console.WriteLine("\nÇıkmak için herhangi bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
