using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class HealthPotion : Item
    {
        public HealthPotion():base("Can İksiri")
        {
            
        }


        public override void Use(Character character)
        {
            int healAmount = 30;   
            character.HP = Math.Min(character.HP, character.HP + healAmount);
            ConsoleHelper.WriteLineColored($"[İYİLEŞME] {character.Name} can iksirini içti. Vicuduna sıcak bir his yayıldı ve {healAmount} HP yenilendi",ConsoleColor.Green);


        }







    }
}
