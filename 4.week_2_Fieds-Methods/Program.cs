using System;
using System.Reflection.PortableExecutable;

namespace _4.week_2_Fieds_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CofeeMachine coffeMachine = new CofeeMachine();

            coffeMachine.Model = "Barista Pro";
            coffeMachine.WaterLevel = 500;
            coffeMachine.CofeeBana = 100;

            coffeMachine.MakeCoffee();

            coffeMachine.AddWater(400);
            coffeMachine.AddCoffeeBeans(100);

            for (int i = 0; i < 3; i++)
            {
                coffeMachine.MakeCoffee();
            }
        }
    }
}
