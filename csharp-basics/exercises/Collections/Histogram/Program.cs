using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "D:\\Documents\\Programming_courses\\INTENSIVE COURSES HOMEWORK\\c-sharp-basic\\csharp-basics\\exercises\\Collections\\Histogram\\midtermscores.txt";

        private static void Main(string[] args)
        {
            string inputNumbers = File.ReadAllText(Path);
            string[] numbers = inputNumbers.Split(" ");
            Dictionary<string, string> histogram = new Dictionary<string, string>
            {
                { "00-09","" },
                { "10-19","" },
                { "20-29","" },
                { "30-39","" },
                { "40-49","" },
                { "50-59","" },
                { "60-69","" },
                { "70-79","" },
                { "80-89","" },
                { "90-99","" },
                { "100","" }
            };

            foreach (var item in numbers)
            {
                if (int.TryParse(item, out int value))
                {
                    switch (value)
                    {
                        case int n when n >= 0 && n <= 9:
                            histogram["00-09"] += "*";
                            break;
                        case int n when n >= 10 && n <= 19:
                            histogram["10-19"] += "*";
                            break;
                        case int n when n >= 20 && n <= 29:
                            histogram["20-29"] += "*";
                            break;
                        case int n when n >= 30 && n <= 39:
                            histogram["30-39"] += "*";
                            break;
                        case int n when n >= 40 && n <= 49:
                            histogram["40-49"] += "*";
                            break;
                        case int n when n >= 50 && n <= 59:
                            histogram["50-59"] += "*";
                            break;
                        case int n when n >= 60 && n <= 69:
                            histogram["60-69"] += "*";
                            break;
                        case int n when n >= 70 && n <= 79:
                            histogram["70-79"] += "*";
                            break;
                        case int n when n >= 80 && n <= 89:
                            histogram["80-89"] += "*";
                            break;
                        case int n when n >= 90 && n <= 99:
                            histogram["90-99"] += "*";
                            break;
                        case int n when n==100:
                            histogram["100"] += "*";
                            break;
                        default:
                            break;
                    }
                }

            }

            foreach (var k in histogram.Keys)
            {
                    Console.WriteLine($"{k.PadLeft(5)}: {histogram[k]}");
            }
        }
    }
}
