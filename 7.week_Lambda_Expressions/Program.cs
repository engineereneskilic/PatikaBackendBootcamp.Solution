using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace _7.week_Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> divide = (x, y) =>
            {
                if(y == 0 ) throw new DivideByZeroException("bölen sıfır olamaz.");

                return x / y;
            };

            Console.WriteLine(divide(8,2));

            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ProcessNumbers(numbers, n => n % 2 == 0);

            Add add = (a, b) => a + b;

            Console.WriteLine(add(1,2));

            Console.WriteLine("-----------------------------------------");

            Func<int, int, int> multiply = (a, b) => a * b;

            Console.WriteLine(multiply(2,5));

            Console.WriteLine("-----------------------------");

            Action<string> print = message => Console.WriteLine(message);

            print("Merhaba Action");

            Console.ReadKey();
        }

        public delegate int Add(int x, int y);

        static void ProcessNumbers(List<int> numbers, Func<int,bool> filter)
        {
            foreach (var item in numbers)
            {
                if(filter(item))
                {
                    Console.WriteLine(item);
                }

            }
        }



    }
}
