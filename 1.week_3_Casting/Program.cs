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


            int num = 123;
            double d= num; // implict casting
                
            double number= 123.5;

            int number_int = (int)number;

            Console.WriteLine(number_int);


            string cnStrNum = "123";

            int k=Convert.ToInt32(cnStrNum);

            //try ve parse
            int.Parse(cnStrNum);

            bool result2 = int.TryParse(cnStrNum, out result);



        }
    }
}