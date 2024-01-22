using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachine : IVendingMachine
    {
        private Money currentMoney;
        public string Manufacturer { get;}

        public bool HasProducts { get; private set; }

        public Money Amount { get; private set; }

        public Product[] Products { get; private set; }

        public VendingMachine(string manufacturer)
        {
            Products = null;
            Manufacturer = manufacturer;
            HasProducts = HasProducts = (Products?.Length ?? 0) > 0;
        }


        public bool AddProduct(string name, Money price, int count)
        {
            if (string.IsNullOrEmpty(name)||count<=0)
            {
                Console.WriteLine("Name or count of the product is invalid:");
                return false;
            }

            if (Products == null)
            {
                Product[]initProduct = new Product[] { new Product() };
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
            Amount = amount;

            if (isValidCoin(amount))
            {        
                return new Money();  
            }
            else
            { 
                return amount;
            }
        }

        public Money ReturnMoney()
        {
            Money moneyReturn = Amount;
            Amount = new Money();
            return moneyReturn;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber >= 0 && productNumber < Products.Length&&!string.IsNullOrEmpty(name)&&amount>0&&price.HasValue)
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

        public void PrintProducts()
        {
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine("Product Name: " + Products[i].Name);
                Console.WriteLine("Product Price: " + Products[i].Price.Euros + "."+Products[i].Price.Cents);
                Console.WriteLine("Product Available Amount: " + Products[i].Available);
                Console.WriteLine();
            }
        }           
    }
}
