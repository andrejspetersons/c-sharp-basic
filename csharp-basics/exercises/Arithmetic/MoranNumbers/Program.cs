using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace MoranNumbers
{
    internal class Program
    {
        public static bool isPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static string Moran(int number)
        {
            char[] digitArray = number.ToString().ToCharArray();
            int sumOfDigits = 0;

            for (int i = 0; i < digitArray.Length; i++)
            {
                sumOfDigits += (int)char.GetNumericValue(digitArray[i]);
            }

            if (number % sumOfDigits == 0 && number !=1)
            {
                int productOfDivision = number / sumOfDigits;
                string result = isPrime(productOfDivision) ? "H" : "M";
                return result;

            }

            return "Neither";

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Input number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Entered number is {Moran(number)} number");
            Moran(133);
        }
    }
}