using System;

namespace _4.week_11_PRATIK_encapsulation_car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yeni bir araba nesnesi oluşturuluyor
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Corolla";
            car1.Color = "Beyaz";
            car1.DoorCount = 4;  // Geçerli kapı sayısı
            car1.DisplayCarInfo();

            // Hatalı kapı sayısı atanıyor
            Car car2 = new Car();
            car2.Brand = "Ford";
            car2.Model = "Connect";
            car2.Color = "Fırtına Grisi";
            car2.DoorCount = 3;  // Geçersiz kapı sayısı
            car2.DisplayCarInfo();

            Console.ReadKey();
        }
    }
}
