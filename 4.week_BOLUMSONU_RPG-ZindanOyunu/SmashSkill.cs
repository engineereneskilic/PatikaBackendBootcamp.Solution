using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class SmashSkill : Skill
    {
        public SmashSkill() : base("Ezici Darbe", 8)
        {


        }

        public override int Use(Character user, ICharacter target)
        {
            return user.Level = 7;   
        }
    }
}
