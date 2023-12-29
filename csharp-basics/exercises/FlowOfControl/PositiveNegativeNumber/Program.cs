using System;
using System.Globalization;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();
            decimal number = Convert.ToDecimal(input, CultureInfo.InvariantCulture);
            Console.WriteLine($"Number is {(number > 0 ? "Positive": (number < 0 ? "Negative" : "Zero"))}");        
        }
    }
}
