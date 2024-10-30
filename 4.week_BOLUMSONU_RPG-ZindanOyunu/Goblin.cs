using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class Goblin : Enemy
    {
        public Goblin(string name, int hp, int mp, int level) : base(name,30,10,1)
        {
            Skills.Add(new SneackAttackSkill(name,5));    

        }

        public override void SpecialMove(Character target)
        {

            ConsoleHelper.WriteLineColored($"{Name} sinsi bir saldırı yapıyor",ConsoleColor.Green);
            Skills[0].Use(this, target);

        }
    }
}
