using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            phoneDirectory.PutNameNumber("Andrey", "37122889933");
            phoneDirectory.PutNameNumber("Mihail", "371222333000");
            string result = phoneDirectory.FindNumber("Andrey");
            string result2= phoneDirectory.FindNumber("Peteris");
            Console.WriteLine(result);
            Console.WriteLine(result2);

            phoneDirectory.Display();
            phoneDirectory.Clear();

            string result3=phoneDirectory.FindNumber("Andrey");
            Console.WriteLine(result3);
        }
    }
}
