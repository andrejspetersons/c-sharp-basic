namespace SavingsAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sumWithdrawal = 0;
            decimal sumDepo = 0;
            decimal sumInterests = 0;

            SavingsAccount savingsAccount;
            Console.Write("How much money is in the account?:");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            savingsAccount = new SavingsAccount(balance);

            Console.Write("Enter the annual interest rate:");
            int annualInterest = Convert.ToInt32(Console.ReadLine());
            savingsAccount.annualInterest = annualInterest;

            Console.Write("How long has the account been opened?");
            int month = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= month; i++)
            {
                Console.Write($"Enter amount deposited for month: {i}:");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                sumDepo += amount;
                savingsAccount.addDeposit(amount);

                Console.Write($"Enter amount withdrawn for month: {i}:");
                decimal withdrawal = Convert.ToDecimal(Console.ReadLine());
                sumWithdrawal += withdrawal;
                savingsAccount.subWithdrawal(withdrawal);

                sumInterests += savingsAccount.calculateMonthlyInterestRate();
                savingsAccount.addMonthlyInterests();            
            }
            Console.WriteLine($"Total deposited: ${sumDepo:F2}");
            Console.WriteLine($"Total withdrawal: ${sumWithdrawal:F2}");
            Console.WriteLine($"Interest earned: ${Math.Round(sumInterests,2)}");
            Console.WriteLine($"Ending balance:${Math.Round(savingsAccount.Balance,2)}");        
        }
    }
}