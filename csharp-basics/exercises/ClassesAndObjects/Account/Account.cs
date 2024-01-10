using System;
using System.Security.Cryptography;

namespace Account
{
    class Account
    {
        public string name { get; set; }
        public double balance { get; private set; }

        public Account(string name,double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void withdrawal(decimal amount)
        {
            balance -= (double)amount;
        }

        public void deposit(decimal amount)
        {
            balance += (double)amount;
        }

        public decimal Getbalance()
        {
            return (decimal)balance;
        }

        public static void Transfer(Account from,Account to,double howMuch)
        {
            from.withdrawal((decimal)howMuch);
            to.deposit((decimal)howMuch);
        }

        public void PrintAccount()
        {
            Console.WriteLine($"Account name: {name}\nBalance: {balance}");  
        }
    }
}
