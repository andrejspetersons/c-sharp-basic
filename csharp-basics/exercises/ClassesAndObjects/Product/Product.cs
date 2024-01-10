using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; private set; }
        public int amount { get; private set; }

        public Product(string name,double priceAtStart,int amountAtStart)
        {
            this.name = name;
            price = priceAtStart;
            amount = amountAtStart;         
        }

        public void ChangePrice(double newPrice)
        {
            price = newPrice;
        }

        public void ChangeQuantity(int newQuantity)
        {
            amount = newQuantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name},price {price} EUR,{amount} units");
        }
    }
}
