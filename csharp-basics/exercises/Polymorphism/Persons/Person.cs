using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persons
{
    internal class Person
    {
        private static int lastId=0;
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public virtual void display()
        {
            Console.WriteLine($"Name: {FirstName}\nSurname: {LastName}\nAddress: {Adress}");
        }

        public Person(string name,string surname,string address)
        {
            id = ++lastId;
            FirstName = name;
            LastName = surname;
            Adress = address;
        }

    }

    class Student : Person
    {
        public double gpa { get; set; }

        public Student(int ID, string name, string surname, string address,double gpa) : base(name, surname, address)
        {
            this.gpa = gpa;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"GPA: {gpa}");
        }
    }

    class Employee : Person
    {
        public string jobTitle;
        public Employee(int ID, string name, string surname, string address,string jobtitle) : base(name, surname, address)
        {
            jobTitle = jobtitle;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Job Title: {jobTitle}");
        }
    }
}
