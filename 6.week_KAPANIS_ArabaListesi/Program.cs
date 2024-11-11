using System;
using System.Collections.Generic;

namespace _6.week_KAPANIS_ArabaListesi
{
    internal class Program
    {

        // Araba sınıfı, araba özelliklerini içerir
        class Car
        {
            public DateTime ProductionDate { get; } = DateTime.Now; // Üretim tarihi, otomatik atanır
            public string SerialNumber { get; set; } // Arabanın seri numarası
            public string Brand { get; set; }        // Arabanın markası
            public string Model { get; set; }        // Arabanın modeli
            public string Color { get; set; }        // Arabanın rengi
            public int DoorCount { get; set; }       // Kapı sayısı
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(); // Arabaları depolamak için liste

            while (true)
            {
                Console.WriteLine("Araba üretmek istiyor musunuz? (e/h)");
                string answer = Console.ReadLine().Trim().ToLower(); // Büyük-küçük harf duyarlılığı kaldırıldı

                if (answer == "h")
                {
                    Console.WriteLine("Program sonlandırıldı.");
                    break;
                }
                else if (answer != "e")
                {
                    Console.WriteLine("Geçersiz cevap! Lütfen e veya h ile yanıt veriniz.");
                    continue;
                }

                // Yeni araba nesnesi oluşturuluyor
                Car newCar = new Car();

                Console.Write("Seri Numarası: ");
                newCar.SerialNumber = Console.ReadLine();

                Console.Write("Marka: ");
                newCar.Brand = Console.ReadLine();

                Console.Write("Model: ");
                newCar.Model = Console.ReadLine();

                Console.Write("Renk: ");
                newCar.Color = Console.ReadLine();

            // Kapı sayısı için kontrol yapıyoruz
            SetDoorCount:
                try
                {
                    Console.Write("Kapı Sayısı: ");
                    newCar.DoorCount = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
                    goto SetDoorCount; // Hatalı girişte tekrar kapı sayısı isteniyor
                }

                // Arabalar listesine ekleniyor
                cars.Add(newCar);

                Console.WriteLine("Başka bir araba oluşturmak istiyor musunuz? (e/h)");
                string anotherCarAnswer = Console.ReadLine().Trim().ToLower();

                if (anotherCarAnswer == "h")
                {
                    break;
                }
            }

            // Arabaların Seri Numaraları ve Markaları listeleniyor
            Console.WriteLine("\nÜretilen Arabalar:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Seri No: {car.SerialNumber}, Marka: {car.Brand}");
            }


        }
    }
}
