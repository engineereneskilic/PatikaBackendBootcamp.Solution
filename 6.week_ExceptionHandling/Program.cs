using System;

namespace _6.week_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;

            while (!isValidInput)
            {
                try
                {
                    Console.Write("Sayı giriniz");

                    string input = Console.ReadLine();

                    int number = Convert.ToInt32(input);
                    isValidInput = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Hatalı veri girdiniz");
                    isValidInput = false;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Girdiğiniz sayı çok büyük yada çok küçük");
                    isValidInput = false;
                }
                finally
                {
                    Console.WriteLine("İşleminiz tamamlandı");


                }

            }
            

            Console.ReadKey();
 
        }
    }
}
