using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hierarchy
{
    class Program
    {
        public static List<Mammal> animalList = new List<Mammal>();
        static void Main(string[] args)
        {
            
            List<Food> foodList = new List<Food> { new Vegetable(), new Meat(), };


            string input = "";
            do
            {
                Random random = new Random();
                int randomQuantity = random.Next(1, 4);
                input = Console.ReadLine()!;
                string[] information = input.Split(" ");
                CreateAnimal(information, foodList, randomQuantity);

            } while(input != "End") ;

            Console.WriteLine(string.Join(",",animalList));                        
        }

        public static void CreateAnimal(string[] information, List<Food> foodList, int quantity)
        {
            CultureInfo culture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culture;

            Random random = new Random();
            int rIndex = random.Next(0, foodList.Count());

            if (information[0]=="End")
            {
                return;
            }

            if (information.Length < 4)
            {
                Console.WriteLine("Insufficient information provided.");
                return;
            }

            Mammal animal;

            switch (information[0].ToLower())
            {
                case "cat":
                    if (information.Length < 5)
                    {
                        Console.WriteLine("Insufficient information for a cat.");
                        return;
                    }

                    animal = new Cat();
                    ((Cat)animal).Breed = information[4];
                    break;

                case "tiger":
                    animal = new Tiger();
                    break;

                case "mouse":
                    animal = new Mouse();
                    break;

                case "zebra":
                    animal = new Zebra();
                    break;

                default:
                    Console.WriteLine($"Unknown animal type: {information[0]}");
                    return;
            }

            animal.AnimalType = information[0];
            animal.AnimalName = information[1];
            animal.AnimalWeight = double.Parse(information[2], culture);
            animal.LivingRegion = information[3];
            animal.FoodEaten = quantity;

            string foodText = $"{foodList[rIndex].GetType().Name} {quantity}";
            Console.WriteLine(foodText);
            animal.Eat(foodList[rIndex]);

            if (!animal.AnimalEatFood(foodList[rIndex]))
            {
                Console.WriteLine($"{information[0]} don't eat that type of food!");
                animal.FoodEaten = 0;
            }
            else
            {
                animal.MakeSound();
            }

        animalList.Add(animal);
        }

    }
}
