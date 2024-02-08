using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string name,double balance)
        {
            Name = name;
            Balance = balance;
        }
        
        public string ShowUserNameAndBalance()
        {
            return $"{Name}, " + Format(Balance);
        }

        public string Format(double balance)
        {         
            return balance < 0 ? $"-${Math.Abs(balance):F2}" : $"${balance:F2}";
        }
    }
}
