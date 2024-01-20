namespace Exercise1
{
    internal class Program
    {
        public static bool isValid(int number1, int number2)
        {
            return number1 == 15 || number2 == 15 || number1 + number2 == 15 || Math.Abs(number1 - number2) == 15;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer");
            int number2 = Convert.ToInt32(Console.ReadLine());

            bool result=isValid(number1 ,number2);          
            Console.WriteLine(result);
        }
    }
}