using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public abstract class Skill
    {
        public string Name { get; set; }

        public int MPCost { get; }

        protected Skill(string name, int mPCost)
        {
            Name = name;
            MPCost = mPCost;
        }
        public abstract int Use(Character user, ICharacter target);
        


    }
}
