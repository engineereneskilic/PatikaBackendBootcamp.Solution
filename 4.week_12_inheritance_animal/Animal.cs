
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _4.week_12_inheritance_animal
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public void Eat() 
        {
            Console.WriteLine($"{Name} yemek yiyor.");
        }

        public abstract void MakeSound();

    }

    public abstract class Mammal: Animal
    {
        public void Nurse()
        {
            Console.WriteLine("Nursing...");
        }
    }

    public class Cat:Mammal
    {
        public override void MakeSound()
        {
                Console.WriteLine("Meow");
        }

    }

    public class Dog: Mammal
    {
  
        public override void MakeSound()
        {
            Console.WriteLine("Barking");
        }
    }

    public class Bird: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Flying");
        }
    }

    public class Sparrow:Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Singing");
        }
    }
   
}
