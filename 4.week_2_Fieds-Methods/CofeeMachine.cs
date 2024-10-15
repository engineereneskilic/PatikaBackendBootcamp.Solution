using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_2_Fieds_Methods
{
    public class CofeeMachine
    {
        private string model;
        private int waterLevel;
        private int coffeeBeans;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int WaterLevel
        {
            get
            {
                return waterLevel;
            }
            set
            {
                waterLevel = value;
            }
        }

        public int CofeeBana
        {
            get
            {
                return coffeeBeans;
            }
            set
            {
                if(value > 0)
                {
                    coffeeBeans = value;
                }
            }
        }


        public void MakeCoffee()
        {
            if (waterLevel > 200 && coffeeBeans >= 15)
            {
                Console.WriteLine("Kahve hazır");

                coffeeBeans -= 15;
                waterLevel -= 200;

            } else
            {
                Console.WriteLine("Yeterli su veya kahve çekirdeği yok.");
            }
        }

        public void AddWater(int amount)
        {
            if(amount > 0)
            {
                waterLevel += amount;
                Console.WriteLine($"{amount} ml su eklendi. Güncel su seviyesi {waterLevel}");
            }

        }

        public void AddCoffeeBeans(int amount) 
        {
            if(amount > 0)
            {
                coffeeBeans += amount;
                Console.WriteLine($"{amount} gram kahve çekirdeği eklendi. Güncel kahve miktarı {coffeeBeans} gram");
            }

        }

    }
}
