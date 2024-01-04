using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            Console.WriteLine("Enter specific value to find:");
            var valueToFind = Convert.ToInt32(Console.ReadLine());
            bool isFound = myArray.Contains(Convert.ToInt32(valueToFind));

            if (isFound)
            {
                Console.WriteLine($"Value {valueToFind} contains in array");
            }
            else
            {
                Console.WriteLine($"Value {valueToFind} not found");
            }

        }
    }
}
