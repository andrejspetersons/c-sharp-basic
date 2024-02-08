using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Channels;
using System.Timers;

namespace Exercise1
{
    class Program
    {

        private static void Main(string[] args)
        {
            string[] brand = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            string[] origination = { "Germany", "Germany", "Japan", "Germany", "Germany", "USA" };
            brand.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine(string.Join(Environment.NewLine,brand.ToHashSet()));

            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < brand.Length; i++)
            {
                if (brand[i]=="Audi"|| brand[i] == "BMW" || brand[i] == "Mercedes" || brand[i] == "VolksWagen")
                {
                    dict[brand[i]] = "Germany";
                }
                else if (brand[i] == "Honda")
                {
                    dict[brand[i]] = "Japan";
                }
                else if (brand[i] == "Tesla")
                {
                    dict[brand[i]] = "USA";
                }
            }

            Console.WriteLine();

            var dictionarySeq = dict.Select(key => key.Key + ":" + key.Value);
            Console.WriteLine(string.Join(Environment.NewLine,dictionarySeq));
        }
    }
}
