namespace VendingMachine
{
    public class NegativeMoneyException:Exception
    {
        public NegativeMoneyException() : base("Money values couldn't be negative")
        {
                
        }
    }
}