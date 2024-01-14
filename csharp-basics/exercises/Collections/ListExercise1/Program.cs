using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colours = new List<string>
            {
                "black",
                "white",
                "blue",
                "green",
                "peacock-blue"
            };

            Console.WriteLine(string.Join(",",colours));
        }
    }
}
