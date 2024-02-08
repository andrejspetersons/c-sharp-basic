using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product(string name,double priceAtStart,int amountAtStart)
        {
            Name = name;
            Price = priceAtStart;
            Amount = amountAtStart;         
        }

        public void ChangePrice(double newPrice)
        {
            Price = newPrice;
        }

        public void ChangeQuantity(int newQuantity)
        {
            Amount = newQuantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name},price {Price} EUR,{Amount} units");
        }
    }
}
