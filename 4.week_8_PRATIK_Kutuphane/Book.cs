using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_8_PRATIK_Kutuphane
{
    public class Book
    {


        // Property (Özellik):
        // Property, bir sınıfın verilerini tutan ve kontrol eden özel niteliklerdir.
        // 'Title', 'AuthorName', 'PageCount' gibi özellikler, Book sınıfının property'leridir.
        //*************************************************************************************************
        // Kitap sınıfı, kitap bilgilerini saklar ve iki constructor sağlar

        // Kitap için gerekli özellikler
        public string Title { get; set; } // Kitap adı
        public string AuthorName { get; set; } // Yazar adı
        public string AuthorSurname { get; set; } // Yazar soyadı
        public int PageCount { get; set; } // Sayfa sayısı
        public string Publisher { get; set; } // Yayınevi
        public DateTime RegistrationDate { get; private set; } // Kayıt tarihi (otomatik atanır)



        // Constructor (Yapıcı Metot): 
        // Constructor, bir sınıfın yeni bir örneği (nesnesi) oluşturulurken çalışan özel bir metottur.
        // Kitap sınıfının constructor'ları, nesne oluşturulurken kitap bilgilerini başlatmak için kullanılır.


        // Default constructor: Parametre almadan çalışan constructor
        public Book()
        {
            // Kayıt Tarihi, kitap oluşturulduğunda otomatik atanır
            RegistrationDate = DateTime.Now;

            // Constructor çağrıldığında ekrana "Kitap kaydedildi" yazdırılır
            Console.WriteLine("Kitap kaydedildi.");
        }

        // Alternatif constructor: Kitap adı, yazar adı, sayfa sayısı, yayınevi bilgilerini alır
        public Book(string title, string authorName, string authorSurname, int pageCount, string publisher)
        {
            // Bu constructor'da girilen bilgileri ilgili property'lere atıyoruz
            Title = title;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            PageCount = pageCount;
            Publisher = publisher;

            // Kayıt Tarihi yine kitap oluşturulduğu anda atanır
            RegistrationDate = DateTime.Now;

            // Constructor çalıştığında ekrana bu kitap için kayıt mesajı yazılır
            Console.WriteLine($"{Title} kitabı başarıyla kaydedildi.");
        }

        // Kitap bilgilerini ekrana yazdıran bir metot
        public void DisplayBookInfo()
        {
            // Kitap detayları ekrana yazdırılır
            Console.WriteLine($"Kitap Adı: {Title}, Yazar: {AuthorName} {AuthorSurname}, Sayfa Sayısı: {PageCount}, Yayınevi: {Publisher}, Kayıt Tarihi: {RegistrationDate}");
        }


    }
}
