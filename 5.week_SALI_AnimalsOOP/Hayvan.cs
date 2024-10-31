using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.week_SALI_AnimalsOOP
{
    public abstract class Hayvan
    {
        public abstract string Tur { get; }

        public abstract void Beslen();

        public abstract void SesCikar();

        public abstract void HareketEt();


        public override string ToString()
        {
            return $"Hayvan ({Tur})";
        }
    }
}
