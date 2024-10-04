using System;

namespace _1.week_PERSEMBE_s06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya 1 ile 7 arasında bir sayı girmesi için mesaj yazdırıyoruz
            Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı girin:");

            // Kullanıcının girdiği sayıyı almak için bir değişken tanımlıyoruz
            // Console.ReadLine() kullanıcının girişini string olarak alır
            string kullaniciGirdisi = Console.ReadLine();

            // Girdiğimiz sayıyı sayısal bir değere (int) çevirmemiz gerekiyor
            // Bu işlem için int.Parse() fonksiyonunu kullanıyoruz
            int gunNumarasi = int.Parse(kullaniciGirdisi);

            // Girilen sayının 1 ile 7 arasında olup olmadığını kontrol ediyoruz
            switch (gunNumarasi)
            {
                case 1:
                    Console.WriteLine("Pazartesi"); // 1 sayısı girildiyse, Pazartesi yazdırıyoruz
                    break;
                case 2:
                    Console.WriteLine("Salı"); // 2 sayısı girildiyse, Salı yazdırıyoruz
                    break;
                case 3:
                    Console.WriteLine("Çarşamba"); // 3 sayısı girildiyse, Çarşamba yazdırıyoruz
                    break;
                case 4:
                    Console.WriteLine("Perşembe"); // 4 sayısı girildiyse, Perşembe yazdırıyoruz
                    break;
                case 5:
                    Console.WriteLine("Cuma"); // 5 sayısı girildiyse, Cuma yazdırıyoruz
                    break;
                case 6:
                    Console.WriteLine("Cumartesi"); // 6 sayısı girildiyse, Cumartesi yazdırıyoruz
                    break;
                case 7:
                    Console.WriteLine("Pazar"); // 7 sayısı girildiyse, Pazar yazdırıyoruz
                    break;
                default:
                    // Eğer 1 ile 7 arasında bir sayı girilmediyse, geçersiz bir giriş olduğunu belirten mesaj yazdırıyoruz
                    Console.WriteLine("Geçersiz gün.");
                    break;
            }

            // Program sonlanmadan önce kullanıcıdan bir tuşa basmasını bekliyoruz
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadKey(); // Konsolu kapatmadan önce kullanıcının bir tuşa basmasını bekliyoruz

        }
    }
}
