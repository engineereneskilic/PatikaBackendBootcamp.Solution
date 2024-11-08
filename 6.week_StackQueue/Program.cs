using System;
using System.Collections.Generic;

namespace _6.week_StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fifo

            Queue<string> stringQueue = new Queue<string>();


            stringQueue.Enqueue("Ali");
            stringQueue.Enqueue("Ayşe");
            stringQueue.Enqueue("Mehmet");

            string FirstPerson = stringQueue.Dequeue();

            Console.WriteLine($"İlk bilet sahibi {FirstPerson}");

            string nextPerson = stringQueue.Peek();

            Console.WriteLine($"Sıradaki kişi {nextPerson}");


            Console.WriteLine("------------------");
            foreach (var item in stringQueue)
            {
                Console.WriteLine(item);
            }

            Stack<string> menu = new Stack<string>();

            menu.Push("Adım Murat");
            menu.Push("Bugün Salı Günü");
            menu.Push("Bugün bugünlerden çarşamba");
            menu.Pop();

            menu.Peek();

            foreach (string item in menu)
            {



            }

        }
    }
}
