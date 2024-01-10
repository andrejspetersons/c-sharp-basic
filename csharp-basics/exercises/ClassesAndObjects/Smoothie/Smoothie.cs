using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothie
{
    internal class Smoothie
    {
        public string[] ingredients { get; set; }

        public Smoothie(string[]Ingredients)
        {
            ingredients = Ingredients;
        }

        public double GetCost()
        {
            //|Strawberries|£1.50 |Banana |£0.50 |Mango |£2.50 |Blueberries |£1.00
            //|Raspberries |£1.00 |Apple |£1.75 |Pineapple |£3.50
            double totalCost =0;

            for (int i = 0; i < ingredients.Length; i++)
            {
                switch (ingredients[i])
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
            return ingredients.Length == 1 ? 
                $"{ingredients[0]} Smoothie" : 
                string.Join(" ",ingredients.Select(ingredient=> 
                ingredient.EndsWith("berries")?ingredient.Replace("berries","berry"):ingredient)) +" Fusion";
        }
        
        public string FormatPrice(double price)
        {
            return $"${price}";
        }
    }
}
