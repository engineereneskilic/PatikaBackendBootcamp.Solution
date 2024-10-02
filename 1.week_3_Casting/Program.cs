using System;

namespace _1.week_3_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // implicit casting küçük bir veri türünün daha büyük birüveri türüne dönüştürülmesi için kullanılır

            string userInput = "42";
            int result = 0; // Dönüşüm başarısız olduğunda varsayılan değer

            int.TryParse(userInput, out result);
            

            Console.WriteLine("Dönüşüm başarılı. Sonuç: " + result);
        }
    }
}