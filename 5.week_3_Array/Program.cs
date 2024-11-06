using System;

namespace _5.week_3_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlanıyor
            int[] numbers = new int[10];

            // Kullanıcıdan 10 adet sayı alarak diziyi dolduruyoruz
            Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1}. sayı: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // 2 - Dizinin elemanlarını foreach döngüsü ile ekrana yazdırıyoruz
            Console.WriteLine("\nGirilen sayılar:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine(); // Satır sonu için

            // 3 - Kullanıcıdan alınan yeni bir değeri 11. eleman olarak diziye ekleme işlemi
            Console.Write("\nYeni bir sayı giriniz (11. eleman): ");
            int newNumber = int.Parse(Console.ReadLine());

            // 11. elemanı eklemek için mevcut diziyi genişletiyoruz
            int[] updatedNumbers = new int[numbers.Length + 1];
            numbers.CopyTo(updatedNumbers, 0); // Mevcut diziyi yeni diziye kopyalıyoruz
            updatedNumbers[10] = newNumber; // Yeni elemanı son sıraya ekliyoruz

            // 4 - Diziyi büyükten küçüğe sıralayıp ekrana yazdırıyoruz
            Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
            Array.Sort(updatedNumbers);
            Array.Reverse(updatedNumbers); // Büyükten küçüğe sıralama

            foreach (int number in updatedNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine(); // Satır sonu

        }
    }
}
