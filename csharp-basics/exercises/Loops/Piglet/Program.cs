namespace Piglet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalscore=0;
            string answer="";
            Console.WriteLine("Welcome to Piglet!");
            while (answer!="n")
            {
                Random random = new Random();
                int diceNumber = random.Next(1, 7);

                if (diceNumber == 1)
                {
                    totalscore = 0;
                    Console.WriteLine($"You rolled {diceNumber}!");
                    Console.WriteLine($"You got {totalscore} points");
                    return;
                }

                totalscore += diceNumber;
                Console.WriteLine($"You rolled a {diceNumber}!");
                Console.Write("Roll again?");
                answer = GetValidAnswer();                 
            }

            Console.WriteLine($"You got {totalscore} points");
        }

        static string GetValidAnswer()
        {
            string answer;
            while (true)
            {
                answer = Console.ReadLine()!;

                if(answer=="yes"||
                   answer=="Yes"||
                   answer=="y"||
                   answer=="n")                    
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!Provide yes or no answer.");
                }
            }

            return answer;
        }
    }
}
