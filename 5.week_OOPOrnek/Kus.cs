using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    public class Kus : Hayvan
    {
        public override string Tur => "Kuş";

        public override void Beslen()
        {
            Console.WriteLine("Yem, buğday yiyor.");
        }

        public override void HareketEt()
        {
            Console.WriteLine("Kanat çırpıyor..");
        }

        public override void SesCikar()
        {
            Console.WriteLine("Kuş sesi çıkarıyor..");
        }
    }
}
