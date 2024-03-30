using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IVendingMachine
    {
        string Manufacturer { get; }
        bool HasProducts { get; }
        Money Amount { get; }
        Product[] Products { get; }
        Money InsertCoin(Money amount);
        Money ReturnMoney();
        bool AddProduct(string name, Money price, int count);
        bool UpdateProduct(int productNumber, string name, Money? price, int amount);
        
    }
}
