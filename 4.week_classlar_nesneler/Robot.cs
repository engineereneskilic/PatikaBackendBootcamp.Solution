using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_classlar_nesneler
{
    public class Robot
    {

        public string name { get; set; }
        public string model { get; set; }
        public int batteryLevel { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Merhaba, benim adım {name} ve modelim {model}");
        }

        public void ChargeBattery()
        {
            batteryLevel = 100;
            Console.WriteLine("Pil şarj edildi");
        }

        public void PerformTask(string task)
        {
            if(batteryLevel >= 0)
            {
                Console.WriteLine($"İşlem başlatıldı: {task}");
                batteryLevel -= 10;
            }
            else
            {
                Console.WriteLine("Pil seviyesi düşük lütfen pili şarj edin.");
            }
        }

    }
}
