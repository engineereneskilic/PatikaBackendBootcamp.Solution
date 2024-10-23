
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_SALI_PropertyDonus
{
    public class Calisan
    {
        private string _ad;
        private int _yas;

        public string Ad
        {
            get { return _ad.ToUpper(); }
            set { _ad = value; }
        }
        public int Yas
        {
            get { return _yas; }
            set { if (value < 0) { throw new Exception("Yaş negatif olamaz"); } _yas = value; }
        }

        public void KunyeYazdir()
        {
            Console.WriteLine($"{Ad} adlı çalışan {Yas} yaşındadır.");
        }

    }
}
