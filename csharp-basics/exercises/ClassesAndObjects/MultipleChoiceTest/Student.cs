using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MultipleChoiceTest
{
    internal class Student : IStudent
    {
        public string[] TestTaken { get => messages.Count == 0 ? new string[] { "No tests taken" } : messages.ToArray(); }
        public List<string> messages = new List<string>();

        public void TakeTest(ITestPaper paper, string[]answers)
        {        
            int maxScore = paper.MarkScheme.Length;
            int score = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] != paper.MarkScheme[i])
                {
                    continue;
                }
                else
                {
                    score += 1;
                }
            }

            double result = (double)score / maxScore * 100;
            string requredResult = Regex.Match(paper.PassMark, "[0-9]+").Value;

            if (result > int.Parse(requredResult))
            {
                string message = $"{paper.Subject}: Passed! ({Math.Round(result)}%)";
                messages.Add(message);
            }
            else
            {
                string message = $"{paper.Subject}: Failed! ({Math.Round(result)}%)";
                messages.Add(message);
            }
        }
    }
}
