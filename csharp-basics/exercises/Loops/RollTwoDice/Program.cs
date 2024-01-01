using System.Diagnostics.CodeAnalysis;

namespace RollTwoDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter desired sum:");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Desired sum {sum}:");
            Random random = new Random();

            while (true)
            {
                int firstDiceNumber = random.Next(1, 7);
                int secondDiceNumber = random.Next(1, 7);
                Console.WriteLine($"{firstDiceNumber} and {secondDiceNumber} = {firstDiceNumber + secondDiceNumber}");

                if (firstDiceNumber + secondDiceNumber == sum)
                {
                    break;
                }
            }
        }
    }
}