using System;

namespace _2.week_11_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void IkiKatinaCikar(ref int sayi)
            {
                sayi += 2;
            }

            int deger = 5;
            IkiKatinaCikar(ref deger);
            Console.WriteLine($"Metottan sonraki değer:{deger}");

           


            void DegerleriDegistir(ref int a, ref int b)
            {
                int temp = a;
                a = b;

                b = temp;
            }

            int sayi1 = 10;
            int sayi2 = 20;

            DegerleriDegistir(ref sayi1, ref sayi2);

            Console.WriteLine($"Sayi 1: {sayi1}");

            Console.WriteLine($"Sayı 2: {sayi2}");


            Console.ReadKey();

        }
    }
}
