namespace Product1ToN
{
    internal class Program
    {
        public static int Factorial(int n)
        {
           
            if (n<=1)
            {
                return 1;
            }

            return n*Factorial(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number counting factorial");
            int number=Convert.ToInt32(Console.ReadLine());

            int result = Factorial(number);
            Console.WriteLine($"Factorial of number {number} = {result}");
        }
    }
}