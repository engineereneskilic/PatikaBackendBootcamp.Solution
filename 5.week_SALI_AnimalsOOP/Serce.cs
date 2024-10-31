using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _5.week_SALI_AnimalsOOP
{
    public sealed class Serce : Kus, IUcabilen
    {
        public override string Tur => "Serçe Kuşu";

        public override void SesCikar()
        {
            //base.SesCikar();
            Console.WriteLine("Cik cik cik..");
        }

        public void Uc()
        {
            Console.WriteLine(Tur + " kanatlarıyla havada uçuyor..");
        }
    }
}
