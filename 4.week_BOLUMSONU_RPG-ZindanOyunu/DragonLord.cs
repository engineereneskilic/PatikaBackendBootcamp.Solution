using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class DragonLord : Enemy
    {
        public DragonLord(string name, int hp, int mp, int level) : base(name,500,200,10)
        {
            Skills.Add(new DragonBreathSkill());

        }

        public override void SpecialMove(Character target)
        {
            ConsoleHelper.WriteLineColored($"{Name} korkunç ejderha nefesini püskürtüyor !",ConsoleColor.DarkRed);
            Skills[0].Use(this, target);
        }




    }
}
