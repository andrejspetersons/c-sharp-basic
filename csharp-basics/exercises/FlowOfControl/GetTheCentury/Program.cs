using System;

namespace GetTheCentury
{
    internal class Program
    {
        public static string Century(int year)
        {
            int century = (year / 100)+1;

            if (century == 21)
            {
                return $"{century}st century";
            }

            return $"{century}th century";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year between 1000 and 2010");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Century(year));
        }
    }
}
