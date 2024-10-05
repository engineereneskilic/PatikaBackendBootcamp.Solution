using System;

namespace _2.week_2_PRATIK_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mesajı yazdırmak için tekrar sayısını belirliyoruz
            int tekrarSayisi = 10; // Mesajın 10 kez yazdırılacağını belirten değişken

            // Döngü kullanarak mesajı 10 kez ekrana yazdırıyoruz
            for (int i = 1; i <= tekrarSayisi; i++)
            {
                // Her döngüde mesajı ekrana yazdırıyoruz
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }

            // Kullanıcı programı kapatmadan önce bir tuşa basmayı bekliyoruz
            Console.ReadKey();
        }
    }
}
