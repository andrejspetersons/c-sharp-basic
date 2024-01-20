namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> wordOptions = new List<string>
            {
               
                "Riga",
                "Daugava",
                "Codelex",
                "GitHub",
                "World"
                
            };

            Random random = new Random();
            string wordToGuess = wordOptions[random.Next(0, wordOptions.Count)];
            string placeholder = new string('_', wordToGuess.Length);
            string missedLetter = string.Empty;
            int guessCount = 10;
            bool gameIsActive = true;

            while (guessCount>0&&gameIsActive)
            {
                Console.WriteLine("==========================\n");
                Console.WriteLine($"Word:{placeholder}\n");
                Console.WriteLine($"Missed:{missedLetter}");
                Console.Write("Guess: ");
                var guess = Console.ReadKey(false);
                Console.WriteLine();

                if (!wordToGuess.Contains(guess.KeyChar,StringComparison.OrdinalIgnoreCase))
                {
                    missedLetter += guess.KeyChar;
                }

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (char.ToLower(wordToGuess[i]) == guess.KeyChar)
                    {
                        placeholder = placeholder.Substring(0, i) + wordToGuess[i] + placeholder.Substring(i + 1);
                    }

                }

                if (placeholder == wordToGuess)
                {
                    Console.WriteLine($"You guess {wordToGuess}!");
                    gameIsActive = false;
                    
                }
                guessCount--;     
                Console.WriteLine(placeholder+"\n");
            }         
        }
    }
}