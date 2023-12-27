namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
           Random random = new Random();
           int numberToGuess = random.Next(1, 101);

           Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
           int number=Convert.ToInt32(Console.ReadLine());

            if (number < numberToGuess)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {numberToGuess}");
            }
            else if (number > numberToGuess)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {numberToGuess}.");
            }
            else
            {
                Console.WriteLine($"You guessed it!  What are the odds?!?");
            }
                
         
        }
    }
}