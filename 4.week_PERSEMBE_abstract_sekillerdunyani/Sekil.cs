
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_PERSEMBE_abstract_sekillerdunyani
{
    public abstract class Sekil
    {
        public virtual string Ad { get; set; }

        public int Genislik { get; set; }

        public int Yukseklik { get; set; }

        public abstract double Alan();

        public abstract double Cevre();



        public override string ToString()
        {
            return $"{Ad} ({Genislik}X{Yukseklik})";
        }


    }
}
