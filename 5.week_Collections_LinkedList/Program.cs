using System;
using System.Collections.Generic;

namespace _5.week_Collections_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList<string> linkedlist = new LinkedList<string>();

            linkedlist.AddLast("Elma");
            linkedlist.AddLast("Armut");

            foreach (string s in linkedlist)
            {
                Console.WriteLine();
            }

            LinkedList<int> numbers = new LinkedList<int>();

            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);

            LinkedListNode<int> node = numbers.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;

            }


        }
    }
}
