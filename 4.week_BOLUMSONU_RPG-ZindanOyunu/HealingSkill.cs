using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class HealingSkill : Skill
    {
        public HealingSkill(string name, int mPCost) : base(name, mPCost)
        {

        }

        public override int Use(Character user, ICharacter target)
        {
            int healAmount = user.Level * 2;
            user.HP = Math.Min(user.HP, user.HP + healAmount);

            ConsoleHelper.WriteLineColored($"[İYİLEŞME] {user.Name} büyülü bir ışıkla sarıldı ve {healAmount} HP iyileşti.",ConsoleColor.Green);

            return 0;
        }

        public virtual void Update(Character target) 
        { 
                
            



        }



    }
}
