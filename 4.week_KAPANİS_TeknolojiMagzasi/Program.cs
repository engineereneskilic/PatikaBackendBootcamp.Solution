using System;

namespace _4.week_KAPANİS_TeknolojiMagzasi
{
    internal class Program
    {

            static void Main(string[] args)
            {
                bool continueProducing = true;

                while (continueProducing)
                {
                    Console.Write("Telefon üretmek için 1'e, bilgisayar üretmek için 2'ye basınız:");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            // Telefon nesnesi oluşturma
                            Telefon newPhone = new Telefon();
                            Console.Write("Telefon Adı: ");
                            newPhone.Name = Console.ReadLine();
                            Console.Write("Seri Numarası: ");
                            newPhone.SerialNumber = Console.ReadLine();
                            Console.Write("Açıklama: ");
                            newPhone.Description = Console.ReadLine();
                            Console.Write("İşletim Sistemi: ");
                            newPhone.OperatingSystem = Console.ReadLine();
                            Console.Write("Türkiye Lisanslı mı? (E/H): ");
                            newPhone.IsTurkishLicensed = Console.ReadLine().ToUpper() == "E";

                            Console.WriteLine("Telefon başarıyla üretildi!\n");
                            newPhone.PrintInfo();
                            Console.WriteLine(newPhone.GetProductName());
                            break;

                        case "2":
                            // Bilgisayar nesnesi oluşturma
                            Bilgisayar newComputer = new Bilgisayar();
                            Console.Write("Bilgisayar Adı: ");
                            newComputer.Name = Console.ReadLine();
                            Console.Write("Seri Numarası: ");
                            newComputer.SerialNumber = Console.ReadLine();
                            Console.Write("Açıklama: ");
                            newComputer.Description = Console.ReadLine();
                            Console.Write("İşletim Sistemi: ");
                            newComputer.OperatingSystem = Console.ReadLine();
                            Console.Write("USB Giriş Sayısı (2 veya 4): ");
                            newComputer.UsbPortCount = int.Parse(Console.ReadLine());
                            Console.Write("Bluetooth Var mı? (E/H): ");
                            newComputer.HasBluetooth = Console.ReadLine().ToUpper() == "E";

                            Console.WriteLine("Bilgisayar başarıyla üretildi!\n");
                            newComputer.PrintInfo();
                            Console.WriteLine(newComputer.GetProductName());
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                            continue;
                    }

                    Console.WriteLine("Başka bir ürün üretmek ister misiniz? (E/H): ");
                    continueProducing = Console.ReadLine().ToUpper() == "E";
                }

                Console.WriteLine("İyi günler dileriz!");
                Console.ReadKey();
            }
           
        }
}
