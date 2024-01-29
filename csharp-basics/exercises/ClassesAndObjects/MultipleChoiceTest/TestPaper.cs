using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTest
{
    internal class TestPaper:ITestPaper
    {
        public string Subject { get; set; }
        public string[] MarkScheme { get; set; }
        public string PassMark { get; set; }

        public TestPaper(string name,string[]answers,string procents)
        {
            Subject = name;
            MarkScheme = answers;
            PassMark = procents;
        }

       
    }
}
