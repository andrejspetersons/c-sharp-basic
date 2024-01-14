using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecryptNumber
{
    internal class Program
    {
        // look at the keyboard.
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var result = cryptedNumbers.Select(str => new string(str.Select(ch => (Convert.ToInt32(ch)-' ').ToString()[0]).ToArray()));
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}
