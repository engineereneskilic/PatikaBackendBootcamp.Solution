using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.week_SALI_DataLIB
{
    public static class Veri
    {
        public static List<Ulke> ulkeler = new List<Ulke>
        {
            new Ulke { Id = "TR", Ad = "Türkiye", Baskent = "Ankara" },
            new Ulke { Id = "US", Ad = "Amerika Birleşik Devletleri", Baskent = "Washington, D.C." },
            new Ulke { Id = "DE", Ad = "Almanya", Baskent = "Berlin" },
            new Ulke { Id = "FR", Ad = "Fransa", Baskent = "Paris" },
            new Ulke { Id = "JP", Ad = "Japonya", Baskent = "Tokyo" },
            new Ulke { Id = "GB", Ad = "Birleşik Krallık", Baskent = "Londra" },
            new Ulke { Id = "IT", Ad = "İtalya", Baskent = "Roma" },
            new Ulke { Id = "ES", Ad = "İspanya", Baskent = "Madrid" },
            new Ulke { Id = "CN", Ad = "Çin", Baskent = "Pekin" },
            new Ulke { Id = "RU", Ad = "Rusya", Baskent = "Moskova" },
            new Ulke { Id = "IN", Ad = "Hindistan", Baskent = "Yeni Delhi" },
            new Ulke { Id = "BR", Ad = "Brezilya", Baskent = "Brezilya Şehri" }

        };

        public static List<Unlu> unluler = new List<Unlu>
        {
                new Unlu { Id = 1, Ad = "Fazıl Say", DogumYili = 1970, Meslek = "Piyanist ve Besteci", UlkeId = "TR" },
        new Unlu { Id = 2, Ad = "Elif Şafak", DogumYili = 1971, Meslek = "Yazar", UlkeId = "TR" },
        new Unlu { Id = 3, Ad = "Sebastian Vettel", DogumYili = 1987, Meslek = "Formula 1 Pilotu", UlkeId = "DE" },
        new Unlu { Id = 4, Ad = "Heidi Klum", DogumYili = 1973, Meslek = "Model ve TV Sunucusu", UlkeId = "DE" },
        new Unlu { Id = 5, Ad = "Leonardo DiCaprio", DogumYili = 1974, Meslek = "Oyuncu", UlkeId = "US" },
        new Unlu { Id = 6, Ad = "Taylor Swift", DogumYili = 1989, Meslek = "Şarkıcı ve Söz Yazarı", UlkeId = "US" },
        new Unlu { Id = 7, Ad = "Marion Cotillard", DogumYili = 1975, Meslek = "Oyuncu", UlkeId = "FR" },
        new Unlu { Id = 8, Ad = "Julien Bam", DogumYili = 1988, Meslek = "YouTuber ve İçerik Üreticisi", UlkeId = "FR" },
        new Unlu { Id = 9, Ad = "Benedict Cumberbatch", DogumYili = 1976, Meslek = "Oyuncu", UlkeId = "GB" },
        new Unlu { Id = 10, Ad = "Ed Sheeran", DogumYili = 1991, Meslek = "Şarkıcı ve Söz Yazarı", UlkeId = "GB" },
        new Unlu { Id = 11, Ad = "Andrea Bocelli", DogumYili = 1958, Meslek = "Opera Tenoru", UlkeId = "IT" },
        new Unlu { Id = 12, Ad = "Chiara Ferragni", DogumYili = 1987, Meslek = "Moda İkonu ve Influencer", UlkeId = "IT" },
        new Unlu { Id = 13, Ad = "Javier Bardem", DogumYili = 1969, Meslek = "Oyuncu", UlkeId = "ES" },
        new Unlu { Id = 14, Ad = "Rafael Nadal", DogumYili = 1986, Meslek = "Tenisçi", UlkeId = "ES" },
        new Unlu { Id = 15, Ad = "A.R. Rahman", DogumYili = 1967, Meslek = "Müzik Bestecisi", UlkeId = "IN" },
        new Unlu { Id = 16, Ad = "Priyanka Chopra", DogumYili = 1982, Meslek = "Oyuncu ve Şarkıcı", UlkeId = "IN" },
        new Unlu { Id = 17, Ad = "Anna Netrebko", DogumYili = 1971, Meslek = "Opera Sanatçısı", UlkeId = "RU" },
        new Unlu { Id = 18, Ad = "Evgeny Kissin", DogumYili = 1971, Meslek = "Piyanist", UlkeId = "RU" },
        new Unlu { Id = 19, Ad = "Jack Ma", DogumYili = 1964, Meslek = "İş İnsanı", UlkeId = "CN" },
        new Unlu { Id = 20, Ad = "Yao Ming", DogumYili = 1980, Meslek = "Basketbolcu", UlkeId = "CN" },
        new Unlu { Id = 21, Ad = "Hayao Miyazaki", DogumYili = 1941, Meslek = "Animatör ve Yönetmen", UlkeId = "JP" },
        new Unlu { Id = 22, Ad = "Naomi Osaka", DogumYili = 1997, Meslek = "Tenisçi", UlkeId = "JP" },
        new Unlu { Id = 23, Ad = "Sir Patrick Stewart", DogumYili = 1940, Meslek = "Oyuncu", UlkeId = "GB" },
        new Unlu { Id = 24, Ad = "Emma Watson", DogumYili = 1990, Meslek = "Oyuncu ve Aktivist", UlkeId = "GB" },
        new Unlu { Id = 25, Ad = "Adriana Lima", DogumYili = 1981, Meslek = "Model", UlkeId = "BR" },
        new Unlu { Id = 26, Ad = "Rodrigo Santoro", DogumYili = 1975, Meslek = "Oyuncu", UlkeId = "BR" },
        new Unlu { Id = 27, Ad = "Penélope Cruz", DogumYili = 1974, Meslek = "Oyuncu", UlkeId = "ES" },
        new Unlu { Id = 28, Ad = "Eros Ramazzotti", DogumYili = 1963, Meslek = "Şarkıcı ve Besteci", UlkeId = "IT" },
        new Unlu { Id = 29, Ad = "Jean Reno", DogumYili = 1948, Meslek = "Oyuncu", UlkeId = "FR" },
        new Unlu { Id = 30, Ad = "Jeff Koons", DogumYili = 1955, Meslek = "Sanatçı", UlkeId = "US" }

        };
     }
}
