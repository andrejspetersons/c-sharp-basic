using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", -17.5);
            BankAccount posAccount = new BankAccount("Positive balance", 17.25);
            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.WriteLine(posAccount.ShowUserNameAndBalance());
        }
    }
}
