namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameRounds = 3;
            while (gameRounds>0)
            {
                Console.WriteLine("Enter your move (Rock,Paper,Scissors):");
                string userMove = Console.ReadLine().ToLower();

                if (userMove == "rock" || userMove == "paper" || userMove == "scissors")
                {
                    string computerMove = GetComputerMove();
                    Console.WriteLine($"Computer's move:{computerMove}");

                    string result = RoundWinner(userMove, computerMove);
                    Console.WriteLine($"Result:{result}\n");
                }

                gameRounds--;          
            }
        }

        static string GetComputerMove()
        {
            string[] options = { "rock", "paper", "scissors" };
            Random random = new Random();
            return options[random.Next(0, options.Length)];
        }

        static string RoundWinner(string userMove, string computerMove)
        {
            if (userMove == computerMove)
            {
                return "Tie!";
            }
            else if(
                (userMove == "rock" && computerMove == "scissors") ||
                (userMove == "paper" && computerMove == "rock") ||
                (userMove == "scissors" && computerMove == "paper")
                )
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }
    }
}