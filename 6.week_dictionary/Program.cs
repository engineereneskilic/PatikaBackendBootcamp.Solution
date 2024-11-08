using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _6.week_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1,"Ali");
            students.Add(2, "Ayşe");

            string student = students[1];

            Console.WriteLine(student);

            if(students.ContainsKey(2))
            {
                students.Add(2, "Veli");
            } else
            {
                students.Add(3, "Veli");
            }

            students.Remove(3);

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> capitals = new Dictionary<string, string>()
            {
                { "Türkiye" , "Ankara" },
                { "Almanya" , "Berlin" },
                { "Fransa" , "Paris" },
            };

            capitals.Add("İtalya", "Roma");

            string capitalOfGermany = capitals["Almanya"];

            Console.WriteLine($"Almanya başkenti: { capitalOfGermany }");


            if(capitals.ContainsKey("Fransa"))
            {
                capitals.Remove("Fransa");
                Console.WriteLine("Fransa başkent bilgisi kaldırıldı");
            }

            foreach (KeyValuePair<string,string> kvp in capitals)
            {

                Console.WriteLine($"Ülke {kvp.Key} başkenti: {kvp.Value}");

            }

        }
    }
}
