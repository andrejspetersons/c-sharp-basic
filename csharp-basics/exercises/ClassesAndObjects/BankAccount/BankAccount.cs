using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        public string name { get; set; }
        public double balance { get; private set; }

        public BankAccount(string name,double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        
        public string ShowUserNameAndBalance()
        {
            return $"{name}, " + Format(balance);
        }

        public string Format(double balance)
        {         
            return balance < 0 ? $"-${Math.Abs(balance):F2}" : $"${balance:F2}";
        }


    }
}
