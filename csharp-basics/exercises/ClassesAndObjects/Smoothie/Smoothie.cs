using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    internal class Smoothie
    {
        public string[] Ingredients { get; set; }

        public Smoothie(string[]ingredients)
        {
            Ingredients = ingredients;
        }

        public double GetCost()
        {
            double totalCost =0;

            for (int i = 0; i < Ingredients.Length; i++)
            {
                switch (Ingredients[i])
                {
                    case "Strawberries":
                        totalCost += 1.5;
                        break;
                    case "Banana":
                        totalCost += 0.5;
                        break;
                    case "Mango":
                        totalCost += 2.5;
                        break;
                    case "Blueberries":
                        totalCost += 1;
                        break;
                    case "Raspberries":
                        totalCost += 1;
                        break;
                    case "Apple":
                        totalCost += 1.75;
                        break;
                    case "Pineapple":
                        totalCost += 3.5;
                        break;
                }
            }
            return  totalCost;
        }

        public double GetPrice()
        {
            return GetCost() + GetCost() * 1.5; 
        }

        public string GetName()
        {
            return Ingredients.Length == 1 ? 
                $"{Ingredients[0]} Smoothie" : 
                string.Join(" ",Ingredients.Select(ingredient=> 
                ingredient.EndsWith("berries")?ingredient.Replace("berries","berry"):ingredient)) +" Fusion";
        }
        
        public string FormatPrice(double price)
        {
            return $"${price}";
        }
    }
}
