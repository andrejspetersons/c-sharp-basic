using System;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "D:\\Documents\\Programming_courses\\INTENSIVE COURSES HOMEWORK\\c-sharp-basic\\csharp-basics\\exercises\\Collections\\FlightPlanner\\flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                
                Console.WriteLine(s);
            }
        }
    }
}
