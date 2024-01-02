using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main()
        {
            int sum = 0;

            Console.WriteLine("Input single-digit numbers or enter ESC to quit.");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                    break;

                if (char.IsDigit(keyInfo.KeyChar))
                {
                    sum += Convert.ToInt32(keyInfo.KeyChar.ToString());
                    Console.Write(keyInfo.KeyChar);
                }

                Console.WriteLine(); 
            }

            Console.WriteLine(sum);
        }
    }

}