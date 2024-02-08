using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var VendingMachine = new VendingMachine("VendingMachineV1_0");
            VendingMachine.AddProduct("Snickers", new Money { Euros = 1, Cents = 0 },10);
            VendingMachine.AddProduct("Bounty", new Money { Euros = 1, Cents = 20 }, 5);

            VendingMachine.PrintProducts();

            
            Money insert=new Money{Euros=3,Cents=50};
            Money result=VendingMachine.InsertCoin(insert);
            Money returnResult = VendingMachine.ReturnMoney();
            Console.WriteLine($"Returned money:{result.Euros}.{result.Cents}");
            Console.WriteLine(returnResult.Euros + "." + returnResult.Cents);

            Money insert1 = new Money { Euros = 2, Cents = 50 };
            Money result1 = VendingMachine.InsertCoin(insert1);
            Money returnResult1 = VendingMachine.ReturnMoney();
            Console.WriteLine($"Returned money:{result1.Euros}.{result1.Cents}");
            Console.WriteLine(returnResult1.Euros + "." + returnResult1.Cents);

        }
    }
}
