using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_classlar_nesneler
{
    public class GameCharacter
    {
        public string name { get; set; }
        public int health { get; set; }
        public int stregth { get; set; }
        public int level { get; set; }

        public void Attack(GameCharacter character)
        {
            Console.WriteLine($"{name} adlı karakter {character.name} adlı karaktere saldırdı.");
            character.health -= stregth;
            Console.WriteLine($"{character.name} adlı karakterin {character.health} sağlık değeri kaldı.");
        }

        public void Heal(int amount)
        {
            health += amount;
            Console.WriteLine($"{name} toplam sağlık değeri {health} çıktı.");
        }

        public void levelUp()
        {
            level++;
            stregth += 10;
            Console.WriteLine($"{name}, {level} e atladı. Güç değeri {stregth}");
        }

    }
}
