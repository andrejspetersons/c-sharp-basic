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
        public decimal Balance { get ;private set; }
        public decimal AnnualInterest { get; set; }

        public decimal GetBalance
        {
            get { return Balance; }
        }

        public SavingsAccount(decimal startingBalance)
        {
            Balance = startingBalance;
        }

        public void subWithdrawal(decimal amount)
        {
            Balance -= amount;
        }

        public void addDeposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal calculateMonthlyInterestRate()
        {
            return Balance* AnnualInterest / 12;
        }

        public void addMonthlyInterests()
        {
            Balance += calculateMonthlyInterestRate();    
        }
    }
}
