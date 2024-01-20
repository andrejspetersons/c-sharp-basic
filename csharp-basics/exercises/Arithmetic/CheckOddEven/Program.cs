namespace CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input whole number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine("bye!");
        }
    }
}