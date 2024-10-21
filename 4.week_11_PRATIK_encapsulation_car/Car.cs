using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_11_PRATIK_encapsulation_car
{
    public class Car
    {
        // Arabanın Marka özelliği
        public string Brand { get; set; }

        // Arabanın Model özelliği
        public string Model { get; set; }

        // Arabanın Renk özelliği
        public string Color { get; set; }

        // Kapı Sayısı özelliği için kapsülleme (encapsulation) uygulanıyor
        private int doorCount;

        // Kapı Sayısı özelliğinin set/get işlemi kapsülleme ile yapılıyor
        public int DoorCount
        {
            get
            {
                return doorCount;
            }
            set
            {
                // Eğer atanan değer 2 veya 4 değilse, uyarı mesajı veriyoruz ve Kapı Sayısını -1 yapıyoruz
                if (value == 2 || value == 4)
                {
                    doorCount = value;  // Geçerli değer atanır
                }
                else
                {
                    Console.WriteLine("Hatalı kapı sayısı! Kapı sayısı 2 veya 4 olmalıdır.");
                    doorCount = -1;  // Hatalı değer için -1 atanır
                }
            }
        }

        // Araba bilgilerini konsola yazdıran metod
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Araba Bilgileri: Marka - {Brand}, Model - {Model}, Renk - {Color}, Kapı Sayısı - {DoorCount}");
        }
    }
}
