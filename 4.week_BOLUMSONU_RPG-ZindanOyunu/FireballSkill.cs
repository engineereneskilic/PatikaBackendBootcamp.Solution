using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class FireballSkill : Skill
    {
        public FireballSkill(string name, int mPCost) : base(name, mPCost)
        {

        }

        public override int Use(Character user, ICharacter target)
        {
            return user.Level = 3;
        }
    }
}
