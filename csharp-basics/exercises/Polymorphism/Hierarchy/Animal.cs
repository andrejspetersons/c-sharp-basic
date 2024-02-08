using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten { get; set; }
        public abstract void MakeSound();
        public abstract void Eat(Food f);
        public abstract bool AnimalEatFood(Food f);
    }
}
