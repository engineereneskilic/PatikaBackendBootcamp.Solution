using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class RestRoom : Room
    {
        public RestRoom(string name) : base(name)
        {

        }

        protected override void PerformAction(Hero hero)
        {
            ConsoleHelper.WriteLineColored($"[DİNLENME] {Name}, huzurlu bir oda! Burada biraz kestirseniz iyi olacak",ConsoleColor.Green);
            hero.HP = hero.MaxHP;
            hero.MP = hero.MaxMP;

            ConsoleHelper.WriteLineColored($"[İYİLEŞME] kısa bir şekerleme yaptınız. HP ve MP niz tamamen yenilendi", ConsoleColor.Green);
                 
        }
    }
}
