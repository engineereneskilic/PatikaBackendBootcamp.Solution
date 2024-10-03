using System;

namespace _1.week_PERSEMBE_ikisayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayıyı Giriniz:");
            int cevap1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz:");
            int cevap2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("İki sayının toplamı: " + (cevap1 + cevap2));



            Console.ReadKey();  
        }
    }
}
