using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Feline
    {
        public string Breed { get; set; }

        public override bool AnimalEatFood(Food f)
        {
            return f is Vegetable || f is Meat;    
        }

        public override void Eat(Food f)
        {
               
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{AnimalType}[{AnimalName},{Breed},{AnimalWeight},{LivingRegion},{FoodEaten}]";
        }
    }
}
