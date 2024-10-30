using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class Troll : Enemy
    {

        public Troll(string name): base(name,100,20,3)
        {
            Skills.Add(new SmashSkill());
        }

        public override void SpecialMove(Character target)
        {
            ConsoleHelper.WriteColored($"{Name} güçlü bir ezme saldırısı yapıyor.",ConsoleColor.Red);
            Skills[0].Use(this, target);   
        }





    }
}
