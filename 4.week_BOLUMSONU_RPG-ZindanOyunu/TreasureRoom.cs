using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class TreasureRoom : Room
    {
        private Item _treasure;

        public TreasureRoom(string name, Item treasure) : base(name)
        {
            _treasure = treasure;
        }


        protected override void PerformAction(Hero hero)
        {
            ConsoleHelper.WriteLineColored($"[HAZİNE] gözleriniz parladı! {Name} de {_treasure.Name} adında bir hazine sandığı buldunuz.",ConsoleColor.Yellow);
            hero.AddItemToInventory(_treasure);
        }

       

    }
}
