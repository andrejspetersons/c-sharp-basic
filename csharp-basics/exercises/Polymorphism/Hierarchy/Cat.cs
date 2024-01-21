using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Feline
    {
        public string breed { get; set; }

        public override bool AnimalEatFood(Food f)
        {
            return f is Vegetable || f is Meat;    
        }

        public override void eat(Food f)
        {
               
        }

        public override void makeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName},{breed},{animalWeight},{livingRegion},{foodEaten}]";
        }
    }
}
