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

            GameCharacter hero = new GameCharacter();
            hero.name = "Hero";
            hero.health = 100;
            hero.stregth = 20;
            hero.level = 20;

            GameCharacter monster = new GameCharacter();
            monster.name = "Monster";
            monster.health = 80;
            monster.stregth = 15;
            monster.level = 1;

            hero.Attack(monster);

            monster.Attack(hero);

            hero.Heal(10);

            hero.levelUp();

            hero.Attack(monster);

            Console.ReadKey();
            
        }
    }
}
