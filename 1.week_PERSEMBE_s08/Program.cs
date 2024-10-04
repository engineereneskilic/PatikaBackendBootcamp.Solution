using System;

namespace _1.week_PERSEMBE_s08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan ay numarasını istemek için mesaj yazdırıyoruz
            Console.WriteLine("Ay no: ");

            // Kullanıcının girdiği değeri alıyoruz ve tam sayıya çeviriyoruz
            int ay = Convert.ToInt32(Console.ReadLine());

            // Gün adedini tutmak için bir değişken tanımlıyoruz
            int adet;

            // Ay numarasına göre gün sayısını belirleyen switch yapısını başlatıyoruz
            switch (ay)
            {
                // Şubat ayı 28 gün olduğu için 2 girildiğinde adet 28 olarak belirleniyor
                case 2:
                    adet = 28;
                    break;

                // 31 gün olan aylar: Ocak, Mart, Mayıs, Temmuz, Ağustos, Ekim, Aralık
                // Aynı işlem olduğu için bu ay numaraları bir arada gruplanmıştır
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    adet = 31;
                    break;

                // Geçersiz bir ay numarası girildiğinde hata mesajı gösteriliyor
                default:
                    Console.WriteLine("Geçersiz bir ay numarası girdiniz !");
                    // Programı sonlandırmak için ReadKey() ile kullanıcıdan bir tuşa basmasını bekliyoruz
                    Console.ReadKey();
                    return; // Programı bu noktada bitiriyoruz
            }

            // Geçerli bir ay girilmişse, gün sayısını ekrana yazdırıyoruz
            Console.WriteLine("Gün adeti: " + adet);

            // Programın sonlanmadan önce kullanıcıdan bir tuşa basmasını bekliyoruz
            Console.ReadKey();
        }
    }
}
