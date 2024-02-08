using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string FileName = "midtermscores.txt";
        private static readonly string Path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

        private static void Main(string[] args)
        {
            Console.WriteLine(Path);
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
               if(int.TryParse(item,out int value))
                {
                    foreach (var range in histogram.Keys)
                    {
                        int lowerValue = int.Parse(range.Split('-')[0]);
                        int upperValue = range.Contains('-') ? int.Parse(range.Split('-')[1]) : lowerValue;

                        if(value>=lowerValue&& value <= upperValue)
                        {
                            histogram[range] += "*";
                            break;
                        }
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
