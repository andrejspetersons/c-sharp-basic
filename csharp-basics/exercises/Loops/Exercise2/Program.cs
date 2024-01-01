using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;          
            Console.WriteLine("Input number of cycles : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                int mul=i * i;
                Console.WriteLine($"Multiplication {i} X {i}= {mul}");
            }

        }
    }
}
