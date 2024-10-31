using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.week_SALI_AnimalsOOP
{
    public abstract class Arac
    {

        public Arac(string ad)
        {
            Console.WriteLine("Arac(string)");
            // read-only property'lerin ilk ataması constructor'da yaplabilir
            // başka metotta yapılamazı
            Ad = ad;
        }

        public string Ad { get; } = "Araç";

        public abstract string HareketSahasi { get; }

        public int YolcuKapasitesi { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
