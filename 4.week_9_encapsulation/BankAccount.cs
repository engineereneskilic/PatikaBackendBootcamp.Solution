using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_9_encapsulation
{
    public class BankAccount
    {
        private string _owner;
        private decimal _amount;
        private decimal _balance;
        private string _accountNumber;

        public BankAccount(string owner, decimal initialBalance, string accountNumber) 
        { 
            _owner = owner;
            _balance = initialBalance;
            _accountNumber = accountNumber;
        }

        public string Owner
        {
            get { return _owner; }
            set {
                    // evlilik vs nedeniyle hesap adı değiştirilebilir
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        _owner = value;
                    }
                    else
                    {
                        Console.WriteLine("Hesap sahibi adı boş geçilemez");
                    }
                }
        }

        public decimal Balance
        {
            get { return _balance; }

        }

        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        public void Deposit(decimal amount)
        {

            if(amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"{amount} para yatırıldı. Yeni bakiye {_balance}");
            }
            else
            {
                Console.WriteLine("Yatırılacak para miktarı sıfırdan büyük olmalıdır.");
            }

        }

        public void Withdraw(decimal amount)
        {
            if(amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} para çekildi. Yeni bakiye {_balance} ");
            }
            else
            {
                Console.WriteLine("yetersiz bakiye !");
            }

        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Hesap Sahibi: { _owner}");
            Console.WriteLine($"Hesap Numarası: { _accountNumber}");
            Console.WriteLine($"Mevcut bakiye: {_balance}");
        }




    }
}
