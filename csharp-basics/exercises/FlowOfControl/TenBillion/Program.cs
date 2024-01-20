using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer (if it is negative, make it positive) and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            int sumOfDigits = 0;
            Console.WriteLine("Input an integer number less than ten billion: ");
            string input = Console.ReadLine();

            if (input.StartsWith('-'))
            {
                input.Replace(input.Substring(0,1),"");
            }

            long number = Convert.ToInt64(input);

            if (number > 10000000000)
            {
                Console.WriteLine("Number is to big");
                return;
            }

            foreach (char ch in number.ToString())
            {
                sumOfDigits += ch -'0';
            }

            Console.WriteLine($"Sum of digits in number {number} is = {sumOfDigits}");      
        }
    }
}
