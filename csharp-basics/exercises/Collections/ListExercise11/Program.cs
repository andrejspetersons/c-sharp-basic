using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceryList = new List<string>
            {
                "Bread",
                "Milk",
                "Eggs"
            };

            groceryList.Add("Apple");
            groceryList.Add("Melon");
            groceryList.Add("Chips");
            groceryList.Add("Lemonade");
            groceryList.Add("Chocolate");
            groceryList.Add("Ice Cream");
            groceryList.Add("Salt");
            groceryList.Add("Dumplings");
            groceryList.Add("Sausages");
            groceryList.Add("Fish");

            groceryList.Insert(5, "Cheese");
            Console.WriteLine(string.Join(",",groceryList));

            groceryList.Insert(groceryList.Count - 1, "Red Wine");
            Console.WriteLine(string.Join(",", groceryList));

            groceryList.Sort();
            Console.WriteLine(string.Join(",", groceryList));

            bool containsValue = groceryList.Contains("Foobar");
            Console.WriteLine(containsValue);

            Console.WriteLine();

            for (int i = 0; i < groceryList.Count; i++)
            {
                Console.WriteLine(groceryList[i]);
            }
        }
    }
}
