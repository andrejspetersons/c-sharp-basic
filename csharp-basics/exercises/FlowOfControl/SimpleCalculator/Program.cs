using System.Globalization;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal result=0;
            Console.WriteLine("Input first number:");
            decimal number1 = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Input second number:");
            decimal number2 = Convert.ToDecimal(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Enter operation to do with numbers");
            char operation = Console.ReadKey().KeyChar;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("\nNot valid operation:");
                    break;
            }

            Console.WriteLine($"\nCalculation result: {result}");           
        }
    }
}