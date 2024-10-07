using System;

namespace _2.week_5_PRATIK_YolArkadasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programın sürekli çalışmasını sağlayacak bir döngü
            while (true)
            {
                // Lokasyonların başlangıç fiyatlarını tanımlayalım
                int bodrumPrice = 4000;
                int marmarisPrice = 3000;
                int cesmePrice = 5000;

                // Kullanıcıdan lokasyonu alalım ve büyük-küçük harf duyarlılığını kaldırmak için ToLower() kullanalım
                Console.WriteLine("Gitmek istediğiniz lokasyonu seçiniz (Bodrum, Marmaris, Çeşme): ");
                string locationInput = Console.ReadLine().ToLower();

                // Geçerli lokasyon kontrolü
                if (locationInput != "bodrum" && locationInput != "marmaris" && locationInput != "çeşme")
                {
                    Console.WriteLine("Hatalı bir lokasyon girdiniz. Lütfen Bodrum, Marmaris veya Çeşme lokasyonlarından birini giriniz.");
                    continue; // Tekrar başa dönerek doğru bir lokasyon alana kadar sorar
                }

                // Lokasyonu değişkende tutalım
                string selectedLocation = locationInput;

                // Kullanıcıdan kişi sayısını alalım
                Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
                int numberOfPeople = Convert.ToInt32(Console.ReadLine());

                // Lokasyon ve genel bilgiler
                Console.WriteLine($"Seçilen lokasyon: {selectedLocation.ToUpper()}");
                if (selectedLocation == "bodrum")
                {
                    Console.WriteLine("Bodrum, tarihi yerleri ve sahilleri ile ünlü. Eğlenceli bir tatil geçirebilirsiniz.");
                }
                else if (selectedLocation == "marmaris")
                {
                    Console.WriteLine("Marmaris, doğal güzellikleri ve koyları ile harika bir tatil yeridir.");
                }
                else
                {
                    Console.WriteLine("Çeşme, plajları ve sıcak atmosferi ile tatilcilerin favori noktalarından biridir.");
                }

                // Ulaşım seçeneği soralım
                int travelCost = 0;
                while (true)
                {
                    Console.WriteLine("Tatilinize nasıl gitmek istersiniz?\n1 - Kara yolu (Kişi başı ulaşım ücreti: 1500 TL)\n2 - Hava yolu (Kişi başı ulaşım ücreti: 4000 TL)");
                    string travelOption = Console.ReadLine();

                    if (travelOption == "1")
                    {
                        travelCost = 1500 * numberOfPeople; // Kara yolu maliyeti
                        break;
                    }
                    else if (travelOption == "2")
                    {
                        travelCost = 4000 * numberOfPeople; // Hava yolu maliyeti
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen 1 ya da 2'yi seçiniz.");
                    }
                }

                // Seçilen lokasyona göre tatil fiyatı belirleyelim
                int locationPrice = 0;
                if (selectedLocation == "bodrum")
                {
                    locationPrice = bodrumPrice * numberOfPeople;
                }
                else if (selectedLocation == "marmaris")
                {
                    locationPrice = marmarisPrice * numberOfPeople;
                }
                else if (selectedLocation == "çeşme")
                {
                    locationPrice = cesmePrice * numberOfPeople;
                }

                // Toplam fiyatı hesaplayalım
                int totalCost = locationPrice + travelCost;

                // Sonuçları ekrana yazdıralım
                Console.WriteLine($"\nTatili planladığınız lokasyon: {selectedLocation.ToUpper()}");
                Console.WriteLine($"Toplam kişi sayısı: {numberOfPeople}");
                Console.WriteLine($"Ulaşım maliyeti: {travelCost} TL");
                Console.WriteLine($"Konaklama maliyeti: {locationPrice} TL");
                Console.WriteLine($"Toplam tatil maliyeti: {totalCost} TL\n");

                // Kullanıcıya başka bir tatil planlamak isteyip istemediğini soralım
                Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
                string continueOption = Console.ReadLine().ToLower();

                if (continueOption == "hayır")
                {
                    Console.WriteLine("İyi günler dileriz!");
                    break; // Programı sonlandırır
                }
            }
        }
    }
}
 
