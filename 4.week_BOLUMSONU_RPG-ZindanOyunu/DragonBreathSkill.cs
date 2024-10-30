﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class DragonBreathSkill : Skill
    {
        public DragonBreathSkill() : base("Ejderha Nefesi",20)
        {



        }

        public override int Use(Character user, ICharacter target)
        {
            return user.Level * 6 + new Random().Next(10, 40);
        }
    }
}
