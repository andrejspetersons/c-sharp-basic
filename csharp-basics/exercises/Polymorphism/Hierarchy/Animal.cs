using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string animalName { get; set; }
        public string animalType { get; set; }
        public double animalWeight { get; set; }
        public int foodEaten { get; set; }
        public abstract void makeSound();
        public abstract void eat(Food f);
        public abstract bool AnimalEatFood(Food f);
    }
}
