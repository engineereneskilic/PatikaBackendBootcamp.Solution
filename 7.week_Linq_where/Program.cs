
using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.week_Linq_where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            var positiveNumbers = numbers.Where(num => num > 0).ToList();

            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("--------------------------------------------");

            var squaredNumbers = numbers.Select(num => num * num);

            foreach (var number in squaredNumbers)
            {

                
            }

            Console.WriteLine("------------------------");

            var personList = numbers.Select(num => new Person { ID = num });

            foreach (var person in personList)
            {
                Console.WriteLine(person.ID);
            }
            Console.WriteLine("-----------------------------------");

            IEnumerable<int> sortedNumbers = numbers.OrderBy(num => num);

            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("-----------------------------------");
            IEnumerable<int> sortedNumbersDesc = numbers.OrderByDescending(num => num);

            var personListAsc = personList.OrderBy(person => person);

            foreach (var person in personListAsc)
            {
                Console.WriteLine(person);
            }



            List<Person> people = new List<Person>();

            people.Add(new Person { Age = 23, Name= "Ahmet"});
            people.Add(new Person { Age = 70, Name= "Enes"});
            people.Add(new Person { Age = 15, Name= "Ayşe"});
            people.Add(new Person { Age = 32, Name= "Fatma"});

            var sortedPeople = people.OrderBy(person => person.Age).ThenBy(person => person.Name);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"Ad: {person.Name} Yaş: {person.Age}");
            }

            
            




            Console.ReadKey();

        }
    }
}
