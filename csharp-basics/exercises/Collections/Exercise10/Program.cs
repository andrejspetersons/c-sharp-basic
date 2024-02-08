using System.Collections.Generic;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>()
            {
                "Chris",
                "Aigar",
                "Dan",
                "Steve",
                "Tyler"
            };

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            names.Clear();
            names.Add("Peter");
            names.Add("Peter");
            names.Add("Tedd");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}