using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public abstract class Character : ICharacter
    {
        public string Name { get; }

        public int HP { get; set; }

        public int MaxHP { get; protected set; }

        public int MP { get; set; }

        public int MaxMP { get; protected set; }

        public int Level { get; set; }

        protected Random Random { get; } = new Random();

        public List<Skill> Skills { get; } = new List<Skill> { };

        public List<Item> Inventory { get; } = new List<Item>();



        protected Character(string name, int maxHp, int maxMp, int level)
        {
            Name = name;
            MaxHP = maxHp;
            MaxMP = maxMp;
            Level = level;
        }


        public virtual void Attack(ICharacter target)
        {

            int damage = Random.Next(Level,Level * 2);
            ConsoleHelper.WriteLineColored($"[SALDIRI] {Name}, {target.Name}' e {damage} hasar veriyor! POW! BAM!",ConsoleColor.Yellow);
            target.TakeDamage(damage);

        }

        public virtual void TakeDamage(int damage)  // karakterin aldığı hasar, her karakter daha az hasar alabileceği için virtual yaptık
        {
            HP -= damage;
            ConsoleHelper.WriteLineColored($"[HASAR] {Name} {damage} hasar alıyor. Ayy! Kalan HP: {HP}", ConsoleColor.Red);
        }


        public virtual void UseSkill(Skill skill, ICharacter target)
        {
            if(MP >= skill.MPCost)
            {
                MP -= skill.MPCost;
                int damage = skill.Use(this,target);
                ConsoleHelper.WriteLineColored($"[BECERİ] {Name}, {target.Name}'e karşı {skill.Name} becerisini kullanıyor! {damage} hasar",ConsoleColor.Cyan);

                if(damage > 0)
                {
                    target.TakeDamage(damage);
                }
                else
                {
                    ConsoleHelper.WriteLineColored($"[HATA] OOps {Name}'in {skill.Name} becerisini kullanmak için yeterli MP'si bulunmuyor!",ConsoleColor.DarkRed);
                }

            }
        }


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



    }
}
