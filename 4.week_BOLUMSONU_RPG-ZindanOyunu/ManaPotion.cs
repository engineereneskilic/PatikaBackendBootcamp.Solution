using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class ManaPotion : Item
    {
        public ManaPotion() : base("Mana İksiri")
        {
            
        }

        public override void Use(Character character)
        {
            int manaAmount = 20;
            character.HP = Math.Min(character.HP, character.MP + manaAmount);
            ConsoleHelper.WriteLineColored($"[MANA] {character.Name} mana iksirini içti ve beyni elektriklenmiş gibi hissetti! {manaAmount} MP yenilendi!", ConsoleColor.Blue);

        }

        public override bool Equals(object obj)
        {
            if(obj is Item otherItem)
                return Name == otherItem.Name;
            return false;
            
        }

  


    }
}
