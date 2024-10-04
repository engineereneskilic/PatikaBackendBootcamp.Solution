using System;

namespace _1.week_PERSEMBE_s10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan ilk sayıyı girmesini istiyoruz
            Console.WriteLine("Birinci sayıyı girin:");
            // Kullanıcının girdiği değeri tam sayıya çevirip bir değişkene atıyoruz
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            // Kullanıcıdan ikinci sayıyı girmesini istiyoruz
            Console.WriteLine("İkinci sayıyı girin:");
            // Kullanıcının girdiği değeri tam sayıya çevirip bir değişkene atıyoruz
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            // Kullanıcıdan hangi işlemi yapmak istediğini sormak için mesaj yazdırıyoruz
            Console.WriteLine("Yapmak istediğiniz işlemi girin (+, -, *, /):");
            // Kullanıcının girdiği işlemi string olarak alıyoruz
            string islem = Console.ReadLine();

            // Sonucu tutmak için bir değişken tanımlıyoruz
            double sonuc;

            // Seçilen işleme göre hesaplama yapmak için switch yapısını kullanıyoruz
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2; // Toplama işlemi
                    break;
                case "-":
                    sonuc = sayi1 - sayi2; // Çıkarma işlemi
                    break;
                case "*":
                    sonuc = sayi1 * sayi2; // Çarpma işlemi
                    break;
                case "/":
                    // Bölme işlemi için sıfıra bölme kontrolü yapıyoruz
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2; // Bölme işlemi
                    }
                    else
                    {
                        // Sıfıra bölme durumu için hata mesajı yazdırıyoruz
                        Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
                        Console.ReadKey();
                        return; // Hata durumunda programı sonlandırıyoruz
                    }
                    break;
                default:
                    // Geçersiz bir işlem girildiğinde hata mesajı yazdırıyoruz
                    Console.WriteLine("Geçersiz işlem");
                    Console.ReadKey();
                    return; // Hata durumunda programı sonlandırıyoruz
            }

            // Tüm işlemler tamamlandıktan sonra sonucu yazdırıyoruz
            Console.WriteLine("Sonuç: " + sonuc);

            // Program sonlanmadan önce bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
