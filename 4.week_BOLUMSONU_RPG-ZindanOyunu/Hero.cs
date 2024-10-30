using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class Hero : Character
    {
        public Hero(string name, int maxHp, int maxMp, int level) : base(name, maxHp, maxMp, level)
        {

        }

        public Hero(string name):base(name, 100, 50, 1)
        {

            Skills.Add(new FireballSkill(name,50));

        }


        public int Experience { get; private set; }



        public void AddItemToInventory(Item item)
        {
            Inventory.Add(item);
            ConsoleHelper.WriteLineColored($"[EŞYA] {Name} yeni bir {item.Name} buldu!", ConsoleColor.Green);
        }

        public void UseItem(Item item)
        {
            if (Inventory.Contains(item))
            {
                item.Use(this);
                Inventory.Remove(item);
            }
            else
            {
                ConsoleHelper.WriteLineColored($"[HATA] hay aksi {Name} in envanterinde {item.Name} yok.", ConsoleColor.DarkRed);
            }

        }


        public void GainExperience(int exp)
        {
            Experience = exp;
            ConsoleHelper.WriteLineColored($"[DENEYİM] {Name} {exp} deneyim puanı kazanıyor. Bilgelik doldu !", ConsoleColor.Green);

            if(Experience >= 100 * Level)
            {
                LevelUp();
            }

        }


        public void LevelUp()
        {
            Level++;
            MaxHP += 20;
            MaxMP += 10;

            HP = MaxHP;
            // 220 1 --> 2
            // 220 - 120

            MP = MaxMP;

            Experience -= 100 * (Level - 1);


            ConsoleHelper.WriteLineColored($"[SEVİYE ATLADI] {Name} seviye atladı !", ConsoleColor.Magenta);


        }




    }
}
