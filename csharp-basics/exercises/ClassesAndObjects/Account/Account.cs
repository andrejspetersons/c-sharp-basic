using System;
using System.Security.Cryptography;

namespace Account
{
    class Account
    {
        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        public Account(string name,decimal balance)
        {
            Name = name;
            Balance = balance;
        }

        public void withdrawal(decimal amount)
        {
            Balance -= amount;
        }

        public void deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal Getbalance()
        {
            return (decimal)Balance;
        }

        public static void Transfer(Account from,Account to,decimal howMuch)
        {
            from.withdrawal(howMuch);
            to.deposit(howMuch);
        }

        public void PrintAccount()
        {
            Console.WriteLine($"Account name: {Name}\nBalance: {Balance}");  
        }
    }
}
