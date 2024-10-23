using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_12_inheritance_animal
{
    public abstract class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving");
        }
    }


    public sealed class Car: Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("driving car...");
        }
    }

    public class Bus: Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bus driving");
        }
    }

    public class PublicBus : Bus
    {
       
    }
}
