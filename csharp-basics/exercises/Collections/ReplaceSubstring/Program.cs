using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };
            var result=words.Select(word => word.Contains("ea")? word.Replace("ea", "*") : word);
            Console.WriteLine(string.Join(",",result));
        }
    }
}
