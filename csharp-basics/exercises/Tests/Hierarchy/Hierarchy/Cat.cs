using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Cat:Feline
    {
        public string breed { get; set; }
        public override void eat(Food f)
        {        
            foodEaten = f.quantity;       
        }
        public override void makeSound()
        {
            animalVoice = "Meow";
        }
    }
}
