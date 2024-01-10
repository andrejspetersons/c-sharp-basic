using System;
using System.Security.Cryptography.X509Certificates;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account accountWithHundred = new Account("Untitled", 100);
            accountWithHundred.deposit(20);
            accountWithHundred.PrintAccount();

            Account Matt = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account", 0);

            Matt.withdrawal(100);
            myAccount.deposit(100);

            Matt.PrintAccount();
            myAccount.PrintAccount();

            Account A = new Account("A", 100);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);

            Account.Transfer(A, B, 50);
            Account.Transfer(B, C, 25);

            A.PrintAccount();
            B.PrintAccount();
            C.PrintAccount();
        }
    }
}
