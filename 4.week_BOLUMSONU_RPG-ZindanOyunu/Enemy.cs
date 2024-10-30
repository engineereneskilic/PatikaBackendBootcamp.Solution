using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public abstract class Enemy : Character
    {

        protected Enemy(string name, int hp, int mp,int level):base(name, hp, mp, level)
        {
          


        }
        public abstract void SpecialMove(Character character);


    }
}
