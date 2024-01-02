using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        public static double fromInchToCm(double height) 
        { 
            return Math.Round(height*2.54, 2); 
    
        }

        public static double fromPoundsToKg(double weight)
        {
            return Math.Round(weight * 0.453592, 2);

        }
        

        
        static void Main(string[] args)
        {
            string  Name,  Eyes,  Teeth,  Hair;
            int  Age,  Height,  Weight;
 
             Name = "Zed A. Shaw";
             Age = 35;
             Height = 74;
             Weight = 180;
             Eyes = "Blue";
             Teeth = "White";
             Hair = "Brown";

            Console.WriteLine("Let's talk about " +  Name + ".");
            Console.WriteLine("He's " +  fromInchToCm(Height) + " centimeters tall.");
            Console.WriteLine("He's " +  fromPoundsToKg(Weight) + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " +  Eyes + " eyes and " +  Hair + " hair.");
            Console.WriteLine("His teeth are usually " +  Teeth + " depending on the coffee.");
            Console.WriteLine("If I add " +  Age + ", " + fromInchToCm(Height) + ", and " + fromPoundsToKg(Weight)
                               + " I get " + ( Age + fromInchToCm(Height) + fromPoundsToKg(Weight)) + ".");

            Console.ReadKey();
        }
    }
}