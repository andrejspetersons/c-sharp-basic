using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Zebra : Mammal
    {
        public override bool AnimalEatFood(Food f)
        {
            return f is Vegetable;
        }

        public override void Eat(Food f)
        {
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeeeaal");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
