using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_PERSEMBE_abstract_sekillerdunyani
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen()
        {
            //default değer atama yöntem
        }

        public override string Ad => "Dikdörtgen";

        public int KoseAdedi { get; } = 4;

        public override double Alan()
        {
            
        }

        public override double Cevre()
        {
            
        }
    }
}
