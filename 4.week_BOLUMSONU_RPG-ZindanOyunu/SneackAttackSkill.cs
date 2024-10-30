using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class SneackAttackSkill : Skill
    {
        public SneackAttackSkill(string name, int mPCost) : base("Sinsi Saldırı",5)
        {



        }

        public override int Use(Character user, ICharacter target)
        {

            return user.Level = 2 + new Random().Next(1, 6);

        }
    }
}
