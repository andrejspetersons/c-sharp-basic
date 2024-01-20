using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;

            Console.WriteLine("The first 10 natural numbers are: ");

            do
            {
                i += 1;
                Console.WriteLine(i);

            } while (i<10);

        }
    }
}
