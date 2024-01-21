using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Mouse : Mammal
    {
        public override bool AnimalEatFood(Food f)
        {
            return f is Vegetable;
        }

        public override void eat(Food f)
        {
       
        }

        public override void makeSound()
        {
            Console.WriteLine("Squeeeak");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
