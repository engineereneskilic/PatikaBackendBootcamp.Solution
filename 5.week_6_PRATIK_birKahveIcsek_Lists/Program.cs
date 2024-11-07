using System;
using System.Collections.Generic;

namespace _5.week_6_PRATIK_birKahveIcsek_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının gireceği kahve isimlerini saklayacağımız liste
            List<string> coffeeList = new List<string>();

            Console.WriteLine("Lütfen 5 adet kahve ismi giriniz:");

            // Kullanıcıdan 5 adet kahve ismi almak için for döngüsü
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Kahve {i + 1}: ");
                string coffeeName = Console.ReadLine(); // Kahve ismini konsoldan al
                coffeeList.Add(coffeeName); // Alınan kahve ismini listeye ekle
            }

            Console.WriteLine("\nGirdiğiniz kahve isimleri:");

            // Foreach döngüsü ile listeyi ekrana yazdırma
            foreach (string coffee in coffeeList)
            {
                Console.WriteLine(coffee); // Listedeki her kahve ismini yazdır
            }

            Console.WriteLine("\nBir kahve içsek bize iyi gelecek! :)");
        }
    }
}
