using System;

namespace _4.week_classlar_nesneler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            robot.name = "Rabot 1";
            robot.batteryLevel = 98;
            robot.model = "K3";

            robot.PerformTask("task 1");

            // hero, monster

            GameCharacter hero = new GameCharacter(); // Kahraman karakteri oluşturulur.
            hero.name = "Hero"; // Karakterin ismi atanır.
            hero.health = 100; // Kahramanın canı 100 olarak belirlenir.
            hero.stregth = 20; // Güç seviyesi atanır.
            hero.level = 20; // Seviyesi atanır.

            GameCharacter monster = new GameCharacter(); // Canavar karakteri oluşturulur.
            monster.name = "Monster"; // Canavarın ismi atanır.
            monster.health = 80; // Canavarın canı 80 olarak belirlenir.
            monster.stregth = 15; // Güç seviyesi atanır.
            monster.level = 1; // Seviyesi atanır.

            hero.Attack(monster); // Kahraman, canavara saldırır.

            monster.Attack(hero); // Canavar, kahramana karşılık verir.

            hero.Heal(10); // Kahraman kendini iyileştirir.

            hero.levelUp(); // Kahraman seviyesini artırır.

            hero.Attack(monster); // Kahraman tekrar saldırır.

            Console.ReadKey();
            
        }
    }
}
