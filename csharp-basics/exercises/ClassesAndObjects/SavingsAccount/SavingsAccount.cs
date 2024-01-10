using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccount
{
    internal class SavingsAccount
    {
        public decimal balance { get ;private set; }
        public decimal annualInterest { get; set; }

        public decimal Balance
        {
            get { return balance; }
        }

        public SavingsAccount(decimal startingBalance)
        {
            balance = startingBalance;
        }

        public void subWithdrawal(decimal amount)
        {
            balance -= amount;
        }

        public void addDeposit(decimal amount)
        {
            balance += amount;
        }

        public decimal calculateMonthlyInterestRate()
        {
            return balance* annualInterest / 12;
        }

        public void addMonthlyInterests()
        {
            balance += calculateMonthlyInterestRate();    
        }


    }
}
