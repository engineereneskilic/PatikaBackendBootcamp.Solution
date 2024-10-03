using System;

namespace _1.week_10_PRATIK_meyve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
            // Meyve fiyatlarının ekrana yazdırıldığı satırlar
            Console.WriteLine("Elma=25 TL");
            Console.WriteLine("Armut=35 TL");
            Console.WriteLine("Çilek=25 TL");
            Console.WriteLine("Muz=35 TL");
            Console.WriteLine("Diğer bütün meyveler=4 TL");

            Console.Write("Hangi meyveyi almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
            // Kullanıcının almak istediği meyveye dair bilgi girişini alıyoruz
            // ToLower() fonksiyonu, kullanıcının girdiği meyveyi küçük harflere çevirir
            string meyve = Console.ReadLine().ToLower();

            // Fiyat değişkeni tanımlanır ve varsayılan olarak 0 TL atanır
            decimal fiyat = 0;

            // Eğer kullanıcı "elma" girdiyse, fiyat 25 TL olarak atanır
            if (meyve == "elma")
            {
                fiyat = 25;
            }
            // Kullanıcı "armut" girdiyse, fiyat 35 TL olur
            else if (meyve == "armut")
            {
                fiyat = 35;
            }
            // Kullanıcı "çilek" girdiyse, fiyat 25 TL olur
            else if (meyve == "çilek")
            {
                fiyat = 25;
            }
            // Kullanıcı "muz" girdiyse, fiyat 35 TL olur
            else if (meyve == "muz")
            {
                fiyat = 35;
            }
            // Yukarıda belirtilen meyveler dışında bir meyve seçildiyse, fiyat 4 TL olarak atanır
            else
            {
                fiyat = 4;
            }

            // Kullanıcının seçtiği meyve ve fiyat bilgisi ekrana yazdırılır
            Console.WriteLine($"Seçtiğiniz meyve: {meyve}, Fiyatı: {fiyat} TL");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bir tuşa basın ve tekrar deneyin");
            Console.ReadKey();

            /************************************************************************************************/
            // Kullanıcıya manav menüsünü göstermek için gerekli bilgiler ekrana yazdırılır.
            Console.Clear();
            Console.WriteLine("Rüya Manavına Hoş Geldiniz!");

            // Fiyat bilgileri ekrana yazdırılır
            Console.WriteLine("Elma=25 TL");
            Console.WriteLine("Armut=35 TL");
            Console.WriteLine("Çilek=25 TL");
            Console.WriteLine("Muz=35 TL");
            Console.WriteLine("Diğer bütün meyveler=4 TL");

            // Kullanıcıya almak istediği meyvenin sorulması
            Console.Write("Hangi meyveyi almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");

            // Kullanıcıdan giriş alınır ve bu giriş küçük harfe çevrilir
            // ToLower() fonksiyonu büyük/küçük harf farkını ortadan kaldırır
            string meyve_ = Console.ReadLine().ToLower();

            // Meyve fiyatı için başlangıç değeri atanır
            decimal fiyat_ = 0;

            // Girilen meyveye göre bir karar yapısı kullanılır. Burada switch-case yapısı tercih edilmiştir.
            switch (meyve_)
            {
                // Eğer kullanıcı "elma" girdiyse bu blok çalışır, fiyat 25 TL olarak atanır.
                case "elma":
                    fiyat_ = 25;
                    break; // Bu blok çalıştıktan sonra diğer case'lere gitmeden çıkılır.

                // Eğer kullanıcı "armut" girdiyse bu blok çalışır, fiyat 35 TL olarak atanır.
                case "armut":
                    fiyat_ = 35;
                    break;

                // Eğer kullanıcı "çilek" girdiyse bu blok çalışır, fiyat 25 TL olarak atanır.
                case "çilek":
                    fiyat_ = 25;
                    break;

                // Eğer kullanıcı "muz" girdiyse bu blok çalışır, fiyat 35 TL olarak atanır.
                case "muz":
                    fiyat_ = 35;
                    break;

                // Eğer yukarıdaki meyveler dışında bir şey girildiyse, bu varsayılan blok çalışır, fiyat 4 TL olarak atanır.
                default:
                    fiyat_ = 4;
                    break;
            }

            // Seçilen meyve ve fiyat bilgisi ekrana yazdırılır
            // String interpolation ($) kullanılarak {fiyat_} değişkeni doğrudan metnin içine yerleştirilir.
            Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat_} TL");

            Console.WriteLine("Programdan çıkmak için bir tuşa basın");
            Console.ReadKey();
        }


    }
}

