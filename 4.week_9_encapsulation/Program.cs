using System;

namespace _4.week_9_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Murat",100,"165184948948923");
            bankAccount.DisplayBalance();

            bankAccount.Deposit(500);

            bankAccount.Withdraw(400);

            bankAccount.DisplayBalance();

            bankAccount.Withdraw(500);

            Console.ReadKey();
        }
    }
}
