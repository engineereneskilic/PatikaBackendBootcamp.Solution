using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public interface ICharacter
    {
        string Name { get; }

        int HP { get; set; }
        int MaxHP { get; }

        int MP { get; set; }
        int MaxMP { get;}
     


        int Level { get; }

        void Attack(ICharacter target);
        void TakeDamage(int damage);




    }
}
