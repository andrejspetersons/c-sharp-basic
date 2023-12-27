using System;
using System.Globalization;
using System.Threading;


namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {

            int chosenOption = GetMenu();
            while (chosenOption != 4)
            {
                switch (chosenOption)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    default:
                        Console.WriteLine("Wrong number was entered.Please choose option from 1 to 4");
                        break;
                }

                chosenOption = GetMenu();
            }

            Console.WriteLine("Program is quiting....");
            Thread.Sleep(2000);
            Console.WriteLine("Program is quited");
        }
  
        public static int GetMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");

            var keyboard = Console.ReadKey(true);
            userChoice = (int)char.GetNumericValue(keyboard.KeyChar);

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            
            Console.WriteLine("What is the circle's radius? ");
            var radiusInput = Console.ReadLine();
            decimal radius = Convert.ToDecimal(radiusInput,CultureInfo.InvariantCulture);

            Console.WriteLine("The circle's area is " + Geometry.AreaOfCircle(radius));

        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("Enter length? ");
            var lengthInput =Console.ReadLine();
            length = Convert.ToDecimal(lengthInput,CultureInfo.InvariantCulture);

            Console.WriteLine("Enter width? ");
            var widthInput = Console.ReadLine();
            width = Convert.ToDecimal(widthInput,CultureInfo.InvariantCulture);

            Console.WriteLine("The rectangle's area is " + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;
            
            Console.WriteLine("Enter length of the triangle's base?\n");
            var groundKeyChar = Console.ReadKey(true);
            ground = (decimal)char.GetNumericValue(groundKeyChar.KeyChar);
            Console.WriteLine(ground);

            Console.WriteLine("Enter triangle's height?\n");
            var heightKeyChar = Console.ReadKey(true);
            height = (decimal)char.GetNumericValue(heightKeyChar.KeyChar);
            Console.WriteLine(height);


            Console.WriteLine("The triangle's area is " + Geometry.AreaOfTriangle(ground, height));
        }

        
    }
}
