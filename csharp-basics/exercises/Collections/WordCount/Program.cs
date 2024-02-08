using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        private const string FileName = "lear.txt";
        private static readonly string Path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

        static void Main(string[] args)
        {
            int charsCount = 0;
            int linesCount = 0;
            int wordCount = 0;
            string readText = File.ReadAllText(Path);

            foreach (char item in readText)
            {
                if (item=='\n')
                {
                    continue;
                }
                else
                {
                    charsCount += 1;
                }
                    
            }

            string[] lines = readText.Split("\n");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] word = Regex.Split(lines[i], @"[ ']", RegexOptions.None);
                for (int j = 0; j < word.Length; j++)
                {
                    if (!string.IsNullOrEmpty(word[j]))
                    {
                        wordCount += 1;
                    }
                       
                }
                linesCount += 1;          
            }

            Console.WriteLine("Lines = "+linesCount);
            Console.WriteLine("Words = "+wordCount);
            Console.WriteLine("Chars = "+charsCount);
        }
    }
}
