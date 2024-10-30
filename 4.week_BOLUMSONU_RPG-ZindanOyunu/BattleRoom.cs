using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_BOLUMSONU_RPG_ZindanOyunu
{
    public class BattleRoom : Room
    {
        private Enemy _enemy;

        public event Func<Hero, Enemy, bool> OnBattle;


        public BattleRoom(string name, Enemy enemy) : base(name)
        {
            _enemy = enemy;
        }

        protected override void PerformAction(Hero hero)
        {

            ConsoleHelper.WriteLineColored($"[SAVAŞ] {Name} da bir gıcırdayan kapıyı açtınız ve ... Eyvah bir {_enemy.Name} belirdi", ConsoleColor.Red);

            bool battleResult = OnBattle?.Invoke(hero, _enemy) ?? false;

            if(battleResult)
            {
                ConsoleHelper.WriteLineColored($"[ZAFER] {_enemy.Name} i yendiniz. Büyük bir zafer :))",ConsoleColor.Green);
            } else
            {
                ConsoleHelper.WriteLineColored($"[YENİLGİ] {_enemy.Name} karşısında yenildiniz :(", ConsoleColor.Red);

            }

        }



    }

    private bool Battle(Hero hero, Enemy enemy)
    {

        while (hero.HP > 0 && enemy.HP > 0)
        {
            PerformTurn(hero, enemy); 
            
            if(enemy.HP > 0 && enemy.HP > 0)
            {
                PerformTurn(enemy, hero);

            } 

            if(enemy.HP <= 0)
            {
                ConsoleHelper.WriteLineColored($"[ZAFER] {enemy.Name} yendiniz. Büyük bir zafer kazandınız",ConsoleColor.Green);
                hero.GainExperience(enemy.Level * 20);
                return true;
            }

            return false;


        }



    }

    private void PerformTurn(ICharacter attacker, ICharacter defender)
    {
        ConsoleHelper.WriteLineColored($"\\n[SIRA] {attacker.Name} in sırası:",ConsoleColor.Yellow);

        ConsoleHelper.WriteLineColored($"HP {attacker.HP}/{attacker.MaxHP}, MP {attacker.MP}/{attacker.MaxMP}",ConsoleColor.Cyan);

        if(attacker is Hero)
        {
            PerformHeroTurn(attacker, defender);
        } else if (attacker is Enemy enemy)
        {
            PerformEnemy();
        }

    }

    private void PerformHeroTurn(Hero hero,ICharacter enemy)
    {
        ConsoleHelper.WriteLineColored("Ne yapmak istersiniz", ConsoleColor.Yellow);
        ConsoleHelper.WriteLineColored("1. Saldır", ConsoleColor.White);
        ConsoleHelper.WriteLineColored("2. Beceri", ConsoleColor.White);
        ConsoleHelper.WriteLineColored("3. Eşya kullan", ConsoleColor.White);

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                hero.Attack(enemy);
                break;
            case "2":
                ChooseAndUseSkill(hero, enemy); 
                break;
            case "3":
                ChooseAndUseSkill(hero, enemy);
                break;
            case "4":
                hero.Attack(enemy);
                break;
            default:
                ConsoleHelper.WriteLineColored("[HATA] geçersiz seçim yaptınız.Heyecandan ne yapacağınızı şaşırdınız ve saldırdınız");
                hero.Attack(enemy);
                break;
            

        }

    }

    private void PerformEnemy(Enemy enemy, ICharacter hero)
    {
        enemy.SpecialMove(hero as Character);
    }

    private void ChooseAndUseSkill(Hero hero, ICharacter enemy)
    {
        if(!hero.Inventory.Any())
        {
            ConsoleHelper.WriteLineColored("[HATA] Çantanız bomboş", ConsoleColor.Yellow);
        }

        ConsoleHelper.WriteLineColored("Hangi beceriyi kullanmak istersiniz?",ConsoleColor.Yellow);

        for(int i=0; i < hero.Skills.Count;i++)
        {
            ConsoleHelper.WriteLineColored($"{i+1}. {hero.Skills[i].Name} (MP maliyeti: {hero.Skills[i].MPCost}",ConsoleColor.White);
        }

        if(int.TryParse(Console.ReadLine(),out int skillChoice) && skillChoice > 0 && skillChoice <= hero.Skills.Count)
        {
            hero.UseSkill(hero.Skills[skillChoice -1 ],enemy);
        } else
        {
            ConsoleHelper.WriteLineColored("[HATA] geçersiz beceri seçimi.",ConsoleColor.Yellow) ;
            hero.Attack(enemy);
        }

        if(int.TryParse(Console.ReadLine(),out int itemChoice) && itemChoice > 0 && itemChoice <= hero.Inventory.Count )
        {
            Item chosenItem = hero.Inventory[itemChoice - 1];
            hero.UseItem(chosenItem);
        } else
        {
            ConsoleHelper.WriteLineColored("[HATA] Eşya seçerken hata yaptınız.",ConsoleColor.DarkRed);
        }

    }

    private void DisplayHeroStatus()
    {
        ConsoleHelper.WriteLineColored("\\n -- Kahraman Durumu ----",ConsoleColor.Cyan);
        ConsoleHelper.WriteLineColored($"Seviye: {_hero.Level}", ConsoleColor.Cyan);
        ConsoleHelper.WriteLineColored($"Seviye: {_hero.Hp}", ConsoleColor.Cyan);
        ConsoleHelper.WriteLineColored($"Seviye: {_hero.Level}", ConsoleColor.Cyan);
        ConsoleHelper.WriteLineColored($"Envanter: {string.Join(",",_hero.inventory).Level}", ConsoleColor.Cyan);

    }




}




