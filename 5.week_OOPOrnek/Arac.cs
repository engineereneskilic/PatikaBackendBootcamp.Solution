using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{

    public abstract class Arac
    {

        public Arac(string ad)
        {
            Console.WriteLine("Arac(string)");
            // read-only property'lerin ilk ataması constructor'da yapılabilir
            // başka metotta yapılamaz
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
