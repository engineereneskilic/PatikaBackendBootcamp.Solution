using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Tavuk : Kus
    {
        public override string Tur => base.Tur + " - Tavuk";

        public override void SesCikar()
        {
            Console.WriteLine("Gıt gıt gıdak! Gıt gıt gıdak!");
        }
    }
}
