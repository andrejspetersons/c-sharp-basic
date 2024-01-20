using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string,string> phoneDirectory { get; set; }

        public PhoneDirectory()
        {
            phoneDirectory = new SortedDictionary<string, string>();
            
        }

        public string FindNumber(string name)
        {
            return phoneDirectory.Count==0?
                    "Dictionary is empty":
                 (phoneDirectory.ContainsKey(name) ? phoneDirectory[name] : "No such number in directory");
        }

        public void PutNameNumber(string name,string number)
        {
            if (!phoneDirectory.ContainsKey(name))
            {
                phoneDirectory.Add(name, number);
            }
            else
            {
                Console.WriteLine($"Name{name} already exists");
            }
        }

        public void Display()
        {
            foreach (var key in phoneDirectory.Keys)
            {
                Console.WriteLine("Name: {0} Number: {1}", key, phoneDirectory[key]);
            }
        }

        public void Clear()
        {
            phoneDirectory.Clear();
        }
    }
}