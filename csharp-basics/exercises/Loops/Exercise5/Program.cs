namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string word1 = Console.ReadLine()!;
            Console.WriteLine("Enter second word:");
            string word2 = Console.ReadLine()!;
            Console.Write(word1);

            for (int i = 1; i <= 30 - (word1.Length + word2.Length); i++)
            {
                Console.Write(".");
            }

            Console.Write(word2);
        }
    }
}