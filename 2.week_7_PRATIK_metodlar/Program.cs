using System;

namespace _2.week_7_PRATIK_metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Void Metot: Geriye değer döndürmeyen bir metot.
            // Sevdiğiniz bir şarkı sözünü ekrana yazdırır.
            void PrintFavoriteSongLyric()
            {
                Console.WriteLine("Sevdiğiniz şarkının sözünü buraya yazın: 'Yazımı kışa çevirdin bak gözümde yaşa leylam! Mevlam ayrılık vermesin gökte uçan kuşa leylaaaaam'");
            }

            // 2. Geriye tamsayı döndüren bir metot.
            // Rastgele bir sayı üretir ve bu sayının 2'ye bölümünden kalanı döndürür.
            int GetRandomNumberMod2()
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretir.
                return randomNumber % 2; // Sayının 2'ye bölümünden kalanı döndürür.
            }

            // 3. Parametre alan ve geriye değer döndüren bir metot.
            // İki sayının çarpımını geriye döndürür.
            int MultiplyTwoNumbers(int number1, int number2)
            {
                return number1 * number2;
            }

            // 4. Parametre alan ve geriye değer döndürmeyen bir metot.
            // Parametre olarak isim ve soyisim alır, ve hoş geldiniz mesajı verir.
            void PrintWelcomeMessage(string firstName, string lastName)
            {
                Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}");
            }

            // Kullanıcıya hangi işlemi yapmak istediğini soralım.
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Şarkı sözü yazdır");
            Console.WriteLine("2 - Rastgele sayı üret ve 2'ye bölümünden kalanı hesapla");
            Console.WriteLine("3 - İki sayının çarpımını hesapla");
            Console.WriteLine("4 - İsim ve soyisim bilgisi al ve hoş geldiniz mesajı ver");

            // Kullanıcıdan seçim alalım
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintFavoriteSongLyric(); // Şarkı sözü yazdırma metodu
                    break;

                case 2:
                    int remainder = GetRandomNumberMod2(); // Rastgele sayı üretme ve 2'ye bölümünden kalanı bulma metodu
                    Console.WriteLine($"Rastgele sayının 2'ye bölümünden kalan: {remainder}");
                    break;

                case 3:
                    // Kullanıcıdan iki sayı alalım
                    Console.Write("İlk sayıyı giriniz: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("İkinci sayıyı giriniz: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    int result = MultiplyTwoNumbers(number1, number2); // İki sayının çarpımını hesaplayan metot
                    Console.WriteLine($"Sonuç: {result}");
                    break;

                case 4:
                    // Kullanıcıdan isim ve soyisim bilgisi alalım
                    Console.Write("İsminizi giriniz: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Soyisminizi giriniz: ");
                    string lastName = Console.ReadLine();

                    PrintWelcomeMessage(firstName, lastName); // Hoş geldiniz mesajı veren metot
                    break;

                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    break;
            }
        }
    }
    }
}
