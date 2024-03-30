using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; private set; }

        public bool HasProducts { get; private set; }

        public Money Amount { get; set; }

        public Product[] Products { get; set; }

        public VendingMachine(string manufacturer)
        {
            Products = null;
            Manufacturer = manufacturer;
            HasProducts = (Products?.Length ?? 0) > 0;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            if (Products == null)
            {
                Product[] initProduct = new Product[]{ new Product() };
                initProduct[0].Name = name;
                initProduct[0].Price = price;
                initProduct[0].Available = count;
                Products = initProduct;
                return true;
            }
            else
            {
                Product[] expandProducts = new Product[Products.Length + 1];
                int i = 0;

                for (i = 0; i < Products.Length; i++)
                {
                    expandProducts[i] = Products[i];
                }

                expandProducts[i] = new Product();
                expandProducts[i].Name = name;
                expandProducts[i].Available = count;
                expandProducts[i].Price = price;
                Products = expandProducts;
                return true;
            }
            
        }

        public Money InsertCoin(Money amount)
        {
            if (amount.Euros < 0 || amount.Cents < 0)
            {
                throw new NegativeMoneyException();
            }

            Amount = amount;

            if (isValidCoin(amount))
            {
                Amount = new Money();
                return Amount;
            }
            else
            {
                return amount;
            }
        }

        public Money ReturnMoney()
        {
            Money moneyForReturn = Amount;
            Amount = new Money();
            return moneyForReturn;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber >= 0 && productNumber < Products.Length && price.HasValue && amount > 0)
            {
                Products[productNumber].Name = name;
                Products[productNumber].Price = (Money)price;
                Products[productNumber].Available = amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isValidCoin(Money coin)
        {
            int[] acceptableEuros = { 1, 2 };
            int[] acceptableCents = { 10, 20, 50 };
            return acceptableEuros.Contains(coin.Euros) && acceptableCents.Contains(coin.Cents);
        }
    }
}
