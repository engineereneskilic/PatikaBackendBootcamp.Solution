using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Kedi : Hayvan
    {
        public override string Tur => "Kedi";
        //public override string Tur
        //{
        //    get
        //    {
        //        return "Kedi";
        //    }
        //}

        public override void Beslen()
        {
            Console.WriteLine("Ciğer yiyor..");
        }

        public override void HareketEt()
        {
            Console.WriteLine("Patileriyle yürüyor..");
        }

        public override void SesCikar()
        {
            Console.WriteLine("Miyav! Miyav! Miyavv!");
        }
    }
}
