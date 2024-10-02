using System;

namespace _1.week_3_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "42";
            int result = 0; // Dönüşüm başarısız olduğunda varsayılan değer

            // Dönüşümü gerçekleştir
            int.TryParse(userInput, out result);

            // Dönüşüm sonucunu kontrol et
            Console.WriteLine("Dönüşüm başarılı. Sonuç: " + result);
        }
    }
}
