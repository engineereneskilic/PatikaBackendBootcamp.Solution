
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_12_inheritance
{
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} yemek yiyor.");
        }

    }

 
}
