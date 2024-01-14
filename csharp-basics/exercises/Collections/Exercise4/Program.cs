using System.Collections.Generic;
using System.Xml;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name="";
            List<string> names = new List<string>();

            do
            {
                Console.Write("Enter name:");
                name = Console.ReadLine()!;
                names.Add(name);
            }
            while (!string.IsNullOrWhiteSpace(name));

            Console.WriteLine("Unique name list contains:"+string.Join(" ",names.Distinct()));
        }
    }
}