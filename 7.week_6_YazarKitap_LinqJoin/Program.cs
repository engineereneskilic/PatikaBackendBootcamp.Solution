using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.week_6_YazarKitap_LinqJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yazarlar tablosu
            List<Author> authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "Orhan Pamuk" },
                new Author { AuthorId = 2, Name = "Elif Şafak" },
                new Author { AuthorId = 3, Name = "Ahmet Ümit" }
            };

            // Kitaplar tablosu
            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
                new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
                new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
                new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
            };

            // LINQ ile Join işlemi
            var query = from book in books
                        join author in authors
                        on book.AuthorId equals author.AuthorId
                        select new
                        {
                            BookTitle = book.Title,
                            AuthorName = author.Name
                        };

            // Sonuçları yazdırma
            Console.WriteLine("Kitaplar ve Yazarlar:");
            foreach (var item in query)
            {
                Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
            }
        }
    }
}
