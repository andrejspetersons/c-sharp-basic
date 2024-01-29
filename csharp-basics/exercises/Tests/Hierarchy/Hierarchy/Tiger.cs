using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Tiger:Feline
    {
        public override void eat(Food f)
        {
            if(f is Meat)
            {
                foodEaten += f.quantity;
            }
        }
        public override void makeSound()
        {
            animalVoice = "Rrrr";
        }


    }
}
