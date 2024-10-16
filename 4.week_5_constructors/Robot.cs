using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_classlar_nesneler
{
    public class Robot
    {

        private string _name { get; set; }
        private string _model { get; set; }
        private int _batteryLevel { get; set; }

        public Robot()
        {

        }


        public Robot(string name, string model, int batteryLevel)
        {
            _name = name;
            _model = model;
            _batteryLevel = batteryLevel;
        }


        ~Robot()
        {

        }





        public void Introduce()
        {
            Console.WriteLine($"Merhaba, benim adım {_name} ve modelim {_model}");
        }

        public void ChargeBattery()
        {
            _batteryLevel = 100;
            Console.WriteLine("Pil şarj edildi");
        }

        public void PerformTask(string task)
        {
            if(_batteryLevel >= 0)
            {
                Console.WriteLine($"İşlem başlatıldı: {task}");
                _batteryLevel -= 10;
            }
            else
            {
                Console.WriteLine("Pil seviyesi düşük lütfen pili şarj edin.");
            }
        }

    }
}
