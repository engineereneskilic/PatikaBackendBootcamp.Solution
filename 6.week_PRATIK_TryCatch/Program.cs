using System;

namespace _6.week_PRATIK_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Lütfen bir sayı giriniz: ");

                try
                {
                    // Kullanıcıdan giriş alınıyor
                    string input = Console.ReadLine();

                    // Giriş sayıya dönüştürülüyor
                    int number = Convert.ToInt32(input);

                    // Sayı geçerliyse karesi hesaplanıp yazdırılıyor
                    Console.WriteLine($"Girilen sayının karesi: {number * number}");

                    isValid = true; // Geçerli bir sayı girişi sağlandığında döngü sonlanacak
                }
                catch (FormatException)
                {
                    // Sayı formatına uygun olmayan girişlerde hata mesajı gösteriliyor
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
                }
            }


        }
    }
}
