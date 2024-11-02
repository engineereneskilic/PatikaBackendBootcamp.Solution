using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_KAPANİS_TeknolojiMagzasi
{
    // Derived class: Bilgisayar
    public class Bilgisayar : BaseMakine
    {
        private int usbPortCount;
        public bool HasBluetooth { get; set; }

        // UsbPortCount özelliği için encapsulation
        public int UsbPortCount
        {
            get => usbPortCount;
            set
            {
                if (value == 2 || value == 4)
                    usbPortCount = value;
                else
                {
                    Console.WriteLine("Hatalı giriş: Usb giriş sayısı 2 veya 4 olmalıdır. Varsayılan değer -1 atandı.");
                    usbPortCount = -1;
                }
            }
        }

        // Ürün Adını Getir metodu
        public override string GetProductName()
        {
            return $"Bilgisayarınızın adı ---> {Name}";
        }

        // BilgileriYazdir metodunu ezme işlemi
        public override void PrintInfo()
        {
            base.PrintInfo(); // Temel bilgileri yazdırır
            Console.WriteLine($"USB Giriş Sayısı: {UsbPortCount}");
            Console.WriteLine($"Bluetooth Var mı?: {HasBluetooth}");
        }
    }
}
