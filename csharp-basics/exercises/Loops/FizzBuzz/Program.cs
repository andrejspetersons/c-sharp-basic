namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max integer:");
            int max = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= max; i++)
            {
                bool moveNextLine = i % 20 == 0;
                bool Fizz = i % 3 == 0;
                bool Buzz = i % 5 == 0;      

                if(Fizz && Buzz)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (Fizz)
                {
                    Console.Write("Fizz ");
                }
                else if(Buzz)
                {
                    Console.Write("Buzz ");
                }             
                else
                {
                    Console.Write(i+" ");
                }

                if (moveNextLine)
                {
                    Console.WriteLine();
                }
               
            }
        }
    }
}