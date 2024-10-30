using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class Game
    {
        private Hero _hero;
        private List<Room> _rooms;
        private DragonLord _dragonLord;

        public Game()
        {
            InitializeGame();
        }


        private void InitializeGame()
        {
            _hero = new Hero("Cesur Maceracı");

            _rooms = new List<Room>
            {
                CreateBattleRoom("Karanlık koridor", new Goblin("Sinsi Goblin",5,5,5)),
                new TreasureRoom("Eski hazine odası",new HealthPotion()),
                new RestRoom("Huzurlu bahçe"),
                CreateBattleRoom("Ateş çukuru",new Troll("Koca Trol")),
                new TreasureRoom("Gizli kasa",new ManaPotion()),
                new RestRoom("Şifalı Pınar"),
                CreateBattleRoom("Büyücünün Kulesi",new Wizard("Kötü büyücü"))
            };

            _dragonLord = new DragonLord("Kızıl Ejderha",5,5,5);
        }

        private BattleRoom CreateBattleRoom(string name, Enemy enemy)
        {
            var battlerRoom = new BattleRoom(name, enemy);
            battlerRoom.OnBattle += Battle;
            return battlerRoom;
        }

        public void Start()
        {
            ConsoleHelper.WriteLineColored("==== Zindan Maceracısı Oyunun Hoşgeldiniz =====",ConsoleColor.Magenta);
            ConsoleHelper.WriteLineColored($"Siz {_hero.Name}, zindandan kaçmaya çalışan cesur bir kahramansınız",ConsoleColor.Cyan);

            foreach (var room in _rooms)
            {
                if(_hero.HP <= 0)
                {
                    ConsoleHelper.WriteLineColored("[Oyun bitti] Maalesef Yenildiinz. Belki bir sonraki sefere!",ConsoleColor.Red);
                    return;

                }

                room.Enter(_hero);
                DisplayHeroStatus();

            }

            if(_hero.HP > 0)
            {

                FinalBassBattle();




            }


        }



    }
}
