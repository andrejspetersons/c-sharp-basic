using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;

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

            Dictionary<char, int> symbolNumbers = new Dictionary<char, int>
            {
                {'!',1 },
                {'@',2 },
                {'#',3 },
                {'$',4 },
                {'%',5 },
                {'^',6 },
                {'&',7 },
                {'*',8 },
                {'(',9 },
                {')',0 },
            };

            var decryptedResult = cryptedNumbers.Select(estr => estr.Select(symbol => symbolNumbers[symbol])).ToList();
            
            foreach (var item in decryptedResult)
            {
                Console.WriteLine(string.Join("",item));

            }


        }
    }
}
