using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal:Animal
    {
        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{AnimalType}[{AnimalName},{AnimalWeight},{LivingRegion},{FoodEaten}]";
        }
    }
}
