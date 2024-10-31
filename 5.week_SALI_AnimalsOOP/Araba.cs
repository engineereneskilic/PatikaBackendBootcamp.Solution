using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.week_SALI_AnimalsOOP
{
    public class Araba : Arac
    {
        public Araba() : base("Araba")
        {
            Console.WriteLine("Araba constructor çalışıyor..");
        }

        public override string HareketSahasi { get { return "Kara"; } }
    }
}
