using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class Wizard : Enemy
    {
        public Wizard(string name) : base(name,50,100,5)
        {
                
        }

        public override void SpecialMove(Character target)
        {
            Skills[0].Use(this, target);
        }
    }
}
