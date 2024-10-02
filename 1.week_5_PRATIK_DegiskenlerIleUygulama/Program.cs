using System;

namespace _1.week_5_PRATIK_DegiskenlerIleUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program Bussiness'ı gereği varsayılan yüzdelik değeri istenen : %10
            const decimal EARNED_PATH_POINTS_PERCENTAGE = 0.1m; //%10

            // Kullacınıcıyı karşılıyoruz
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

            // Kullanıcının kimlik bilgisini alıyoruz
            Console.Write("T.C Kimlik Numarası: ");
            string turkishIDNumber = Console.ReadLine();
            // Not: T.C kimlik numrası 11 haneli sayılardan oluşur. Biz string olarak aldık çünkü hem bellekte fazla yer almaması için hemde herhangi bir işlemde daha sonradan kullanılmayacaktır sadece depo etmek için kullanılacaktır.

            // Kullanıcının Adını alıyoruz.
            Console.Write("Adı: ");
            string name = Console.ReadLine();

            // Kullanıcının Soyadını alıyoruz.
            Console.Write("Soyadı: ");
            string surname = Console.ReadLine();

            // Kullanıcının telefon numarasını alıyoruz
            Console.Write("Telefon Numarası: ");
            string telephoneNumber = Console.ReadLine();
            // Not: Telefon numrası 11 haneli sayılardan oluşur. Biz string olarak aldık çünkü hem bellekte fazla yer almaması için hemde herhangi bir işlemde daha sonradan kullanılmayacaktır sadece depo etmek için kullanılacaktır.


            // Kullanıcının Yaşını alıyoruz.
            Console.Write("Yaş: ");
            string age = Console.ReadLine();

            // Kullanıcının ilk aldığı ürünün Fiyatını istiyoruz.
            Console.Write("İlk aldigi Ürünün Fiyati:");
            decimal firstPurchasedProductPrice = Convert.ToDecimal(Console.ReadLine());

            // Kullanıcının ikinci aldığı ürünün Fiyatını istiyoruz.
            Console.Write("İkinci aldigi Ürünün Fiyati:");
            decimal secondPurchasedProductPrice = Convert.ToDecimal(Console.ReadLine());

            // Kullanıcının iki ürün içim toplam harcadığı ücreti hesaplıyoruz.
            decimal firstAndSecondProductTotalPrice = firstPurchasedProductPrice + secondPurchasedProductPrice;

            decimal discountedPriceforPatika = firstAndSecondProductTotalPrice * EARNED_PATH_POINTS_PERCENTAGE;


            //NOT: Decimal veri tipi parasal değerler için en uygun değişken türüdür. Yuvarlamalara daha müsaittir.
            //NOT: 10 haneli 11 haneli gibi uzun ard arda gelen sayısal değerler için eğer sadece depoloma için(veritabanında saklama yada gecici değişkende tutma) kullanılacak ise string olarak tutulması bellekte daha az yer kaplamasına ve daha kullanışlı olmasını sağlayacaktır.

            Console.WriteLine("-------------------------------------------------------------------------------------");
            // İstenilen Formatta Bilgileri ekranda gösterilmek üzere düzenliyoruz ve sonrasında yazdırıyoruz.

            Console.WriteLine(turkishIDNumber + " Tc numarali " + name + " " + surname + " isimli kişi için kayıt oluşturulmuştur.");
            Console.WriteLine(telephoneNumber +" telefon numarasina bildirim gönderilmiştir.");
            Console.WriteLine($"{firstAndSecondProductTotalPrice} toplam harcama karşılığı kazanılan {(EARNED_PATH_POINTS_PERCENTAGE * 100).ToString("0.#")}% patika puan miktari -> {discountedPriceforPatika.ToString("0.#")} 'dir.");

            //Not: discountedPriceforPatika.ToString("P0")  > yüzdelik için kullanılır ama program sağda istemiş o nedenle yapmadım   %10 değil 10% istenmiş
            // Not: discountedPriceforPatika.ToString("0.#") > virgülden sonra kaç basamak gösterilsin için kullanılır 55,5 olsa göster ama 55,0 ise 55 olarak göstersin diye bu şekilde yaptım
        }
    }
}
