using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Tiger : Feline
    {
        public override bool AnimalEatFood(Food f)
        {
            return f is Meat;
        }

        public override void eat(Food f)
        {
            //doesTheAnimalEatFood(f);  
        }

        public override void makeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
