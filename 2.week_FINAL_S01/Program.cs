using System;
using System.Collections.Generic;

namespace _2.week_FINAL_S01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Merhaba Dünyası
            static void MerhabaDunyasi()
            {
                // Ekrana sırasıyla verilen ifadeleri yazdırıyoruz
                Console.WriteLine("Merhaba");
                Console.WriteLine("Nasılsın ?");
                Console.WriteLine("İyiyim");
                Console.WriteLine("Sen nasılsın ?");
            }

            // 2. Metinsel ve Sayısal Değişkenler
            static void MetinVeSayiDegiskenleri()
            {
                // String ve integer veri tipinde iki değişken tanımlıyoruz
                string metin = "Hello World";
                int sayi = 25;

                // Değerleri ekrana yazdırıyoruz
                Console.WriteLine("Metinsel veri: " + metin);
                Console.WriteLine("Tamsayı veri: " + sayi);
            }

            // 3. Rastgele Sayı Üretme
            static void RastgeleSayiUret()
            {
                // Rastgele bir sayı oluşturmak için Random sınıfını kullanıyoruz
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(1, 100); // 1 ile 100 arasında rastgele sayı üretir
                Console.WriteLine("Rastgele Sayı: " + rastgeleSayi);
            }

            // 4. Rastgele Sayının 3'e Bölümünden Kalan
            static void UcBolumundenKalan()
            {
                Random rnd = new Random();
                int rastgeleSayi = rnd.Next(1, 100);
                Console.WriteLine("Rastgele Sayı: " + rastgeleSayi);
                Console.WriteLine("3'e bölümünden kalan: " + rastgeleSayi % 3);
            }

            // 5. Yaş Kontrolü
            static void YasKontrolu()
            {
                Console.WriteLine("Yaşınızı giriniz: ");
                int yas = Convert.ToInt32(Console.ReadLine());

                if (yas > 18)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }

            // 6. Aynı Cümleyi 10 Kez Yazdırma
            static void CumleYazdir()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
                }
            }

            // 7. İsimlerin Yerlerini Değiştirme
            static void IsimDegistir()
            {
                Console.WriteLine("İlk ismi giriniz: ");
                string isim1 = Console.ReadLine();
                Console.WriteLine("İkinci ismi giriniz: ");
                string isim2 = Console.ReadLine();

                // İsimlerin yerini değiştirme
                string temp = isim1;
                isim1 = isim2;
                isim2 = temp;

                Console.WriteLine("Yer değiştirilmiş isimler: " + isim1 + " " + isim2);
            }

            // 8. Değer Döndürmeyen Metot
            static void DegerDondurmeyenMetot()
            {
                Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
            }

            // 9. İki Sayının Toplamını Döndüren Metot
            static int ToplamHesapla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            // 10. True/False İle String Döndüren Metot
            static string DogruYanlisCevap(bool deger)
            {
                return deger ? "Doğru" : "Yanlış";
            }

            // 11. En Yaşlı Kişiyi Döndüren Metot
            static int EnYasliBul(int yas1, int yas2, int yas3)
            {
                return Math.Max(yas1, Math.Max(yas2, yas3));
            }

            // 12. Sınırsız Sayı Alıp En Büyüğünü Dönen Metot
            static int EnBuyukSayi()
            {
                List<int> sayilar = new List<int>();
                string devam = "evet";

                while (devam == "evet")
                {
                    Console.WriteLine("Bir sayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    sayilar.Add(sayi);

                    Console.WriteLine("Devam etmek istiyor musunuz? (evet/hayır): ");
                    devam = Console.ReadLine();
                }

                return Math.Max(sayilar.ToArray());
            }

            // 13. İki İsim Değiştirme Metodu
            static void IsimYerDegistir(string isim1, string isim2)
            {
                string temp = isim1;
                isim1 = isim2;
                isim2 = temp;

                Console.WriteLine("Yer değiştirilmiş isimler: " + isim1 + " " + isim2);
            }

            // 14. Sayının Tek mi Çift mi Olduğunu Dönen Metot
            static bool TekCiftKontrol(int sayi)
            {
                return sayi % 2 == 0;
            }

            // 15. Hız ve Zaman İle Yol Hesaplama
            static int YolHesapla(int hiz, int zaman)
            {
                return hiz * zaman;
            }

            // 16. Yarıçap Verilen Dairenin Alanını Hesaplama
            static double DaireAlani(double yariCap)
            {
                return Math.PI * yariCap * yariCap;
            }

            // 17. Harflerin Büyük-Küçük Dönüşümü
            static void HarfDonusturme(string metin)
            {
                Console.WriteLine(metin.ToUpper());
                Console.WriteLine(metin.ToLower());
            }

            // 18. Metindeki Boşlukları Silme
            static void BoslukSil()
            {
                string metin = "    Selamlar   ";
                Console.WriteLine(metin.Trim());
            }

            // Main metodu
            static void Main(string[] args)
            {
                // Yöntemleri çağırmak için buradan başlatabilirsiniz
                MerhabaDunyasi();
                MetinVeSayiDegiskenleri();
                RastgeleSayiUret();
                UcBolumundenKalan();
                YasKontrolu();
                CumleYazdir();
                IsimDegistir();
                DegerDondurmeyenMetot();
                Console.WriteLine("Toplam: " + ToplamHesapla(10, 20));
                Console.WriteLine(DogruYanlisCevap(true));
                Console.WriteLine("En yaşlı: " + EnYasliBul(25, 30, 45));
                Console.WriteLine("En büyük sayı: " + EnBuyukSayi());
                IsimYerDegistir("Ali", "Veli");
                Console.WriteLine("Tek mi çift mi: " + TekCiftKontrol(5));
                Console.WriteLine("Yol: " + YolHesapla(80, 2));
                Console.WriteLine("Daire Alanı: " + DaireAlani(5));
                HarfDonusturme("Zaman bir GeRi SayIm");
                BoslukSil();
            }
        }
    }
}
