namespace CozaLozaWoza
{
    internal class Program
    {
        /*
         Write a program called CozaLozaWoza which prints the numbers 1 to 110, 11 numbers per line. 
        The program shall print "Coza" in place of the numbers which are multiples of 3, 
        "Loza" for multiples of 5, "Woza" for multiples of 7, "CozaLoza" for multiples of 3 and 5, and so on. The output shall look like:
         */
        static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 110;
           
            for(int i = lowerBound; i <= upperBound; i++)
            {
                bool dividedByThree = i % 3 == 0;
                bool dividedByFive = i % 5 == 0;
                bool dividedBySeven = i % 7 == 0;
                bool moveToNextLine = i % 11 == 0;

                if (dividedByThree && dividedByFive && dividedBySeven)
                {
                    Console.Write("CozaLozaWoza ");
                    continue;
                }
                else if (dividedByThree && dividedByFive)
                {
                    Console.Write("CozaLoza ");
                    continue;
                }
                else if(dividedByThree && dividedBySeven)
                {
                    Console.Write("CozaWoza ");
                    continue;
                }
                else if (dividedByFive && dividedBySeven)
                {
                    Console.Write("WozaLoza ");
                    continue;
                }


                if (dividedByThree)
                {
                    Console.Write("Coza ");
                }
                else if (dividedByFive)
                {
                    Console.Write("Loza ");
                }
                else if (dividedBySeven)
                {
                    Console.Write("Woza ");
                }
                else
                {
                    Console.Write(i + " ");
                }
                

                if (moveToNextLine)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
