namespace NumberSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter min");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <=max; i++)
            {
                for(int j = i; j <= max; j++)
                {
                    Console.Write(j);               
                }
                for (int k = min; k < i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();               
            }          
        }
    }
}