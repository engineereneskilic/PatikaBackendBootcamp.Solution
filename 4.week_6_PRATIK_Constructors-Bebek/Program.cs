using System;

namespace _4.week_6_PRATIK_Constructors_Bebek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre almayan default constructor ile bir bebek nesnesi oluşturuyoruz
            Bebek bebek1 = new Bebek();
            Console.WriteLine($"Bebek 1: Ad - {bebek1._ad}, Soyad - {bebek1._soyad}, Doğum Tarihi - {bebek1._dogumTarihi}");

            // Ad ve Soyad parametreleri ile alternatif constructor kullanarak bir bebek nesnesi oluşturuyoruz
            Bebek bebek2 = new Bebek("Ayşe", "Yılmaz");
            Console.WriteLine($"Bebek 2: Ad - {bebek2._ad}, Soyad - {bebek2._soyad}, Doğum Tarihi - {bebek2._dogumTarihi}");

            Console.ReadKey();
        }
    }
}
