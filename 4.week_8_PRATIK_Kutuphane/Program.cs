using System;

namespace _4.week_8_PRATIK_Kutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new Anahtar Kelimesi:
            // 'new' anahtar kelimesi, bir sınıfın yeni bir nesnesini oluşturmak için kullanılır.
            // Aşağıda 'Book' sınıfından bir nesne oluşturuluyor.

            // Default constructor ile bir kitap nesnesi oluşturuyoruz
            Book defaultBook = new Book();
            // Default olarak girilen kitabın bilgilerini ekrana yazdırıyoruz
            defaultBook.DisplayBookInfo();

            // Alternatif constructor ile bir kitap nesnesi oluşturuyoruz
            Book specificBook = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
            // Girilen kitap bilgilerini ekrana yazdırıyoruz
            specificBook.DisplayBookInfo();

            // Programın kapanmaması için bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
