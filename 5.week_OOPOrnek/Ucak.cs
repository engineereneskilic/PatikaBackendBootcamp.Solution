using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Ucak : Arac, IUcabilen
    {
        public Ucak() : this(120)
        {
            Console.WriteLine("Ucak()");
        }

        public Ucak(int yolcuKapasitesi) : base("Uçak")
        {
            Console.WriteLine("Ucak(int)");
            YolcuKapasitesi = yolcuKapasitesi;
        }

        public override string HareketSahasi => "Hava";

        public void Uc()
        {
            Console.WriteLine(Ad + " yüksek irtifada uçuyor.");
        }
    }
}
