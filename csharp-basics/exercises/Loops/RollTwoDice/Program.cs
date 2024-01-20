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
            int firstDiceNumber = 0;
            int secondDiceNumber = 0;
                
            while (firstDiceNumber+secondDiceNumber!=sum)
            {
                firstDiceNumber = random.Next(1, 7);
                secondDiceNumber = random.Next(1, 7);
                Console.WriteLine($"{firstDiceNumber} and {secondDiceNumber} = {firstDiceNumber + secondDiceNumber}");
            }
        }
    }
}