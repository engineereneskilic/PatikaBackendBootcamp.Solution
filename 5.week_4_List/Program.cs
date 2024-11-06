using System;
using System.Collections.Generic;

namespace _5.week_4_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3,4,5 };

            List<string> friuts = new List<string>() { "Elma", "Armut" , "Muz" };

            numbers.Add(6);
            numbers.Insert(2, 10); // 2.indexten sonra 10 ekle
            numbers.Remove(4);

            numbers.RemoveAt(4);
            numbers.Contains(3);

            numbers.Clear();

            numbers.Reverse();

            foreach (int item in numbers)
            {
                Console.WriteLine(item);

            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);

            }



        }
    }
}
