using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _7.week_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            var eventNumbers = from number in numbers
                               where number % 2 == 0
                               select number;
            foreach ( var number in eventNumbers )
            {
                Console.WriteLine(number);


            }

            Console.WriteLine("----------------------------------");


            var evenNumbers2 = numbers.Where(x => x % 2 == 0);

            foreach (var item in evenNumbers2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
