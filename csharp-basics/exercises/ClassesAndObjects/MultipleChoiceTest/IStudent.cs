using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTest
{
    internal interface IStudent
    {
        string[] TestTaken { get;}
        void TakeTest(ITestPaper paper, string[]answers);
    }
}
