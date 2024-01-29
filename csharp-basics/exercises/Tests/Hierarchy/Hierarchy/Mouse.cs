using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public override void eat(Food f)
        {
            if(f is Vegetable)
            {
                foodEaten += f.quantity;
            }
        }

        public override void makeSound()
        {
            animalVoice = "Squick";
        }
    }
}
