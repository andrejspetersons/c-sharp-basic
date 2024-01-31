using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persons
{
    internal class Person
    {
        private static int _lastId=0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public virtual void display()
        {
            Console.WriteLine($"Name: {FirstName}\nSurname: {LastName}\nAddress: {Adress}");
        }

        public Person(string name,string surname,string address)
        {
            Id = ++_lastId;
            FirstName = name;
            LastName = surname;
            Adress = address;
        }

    }

    class Student : Person
    {
        public double Gpa { get; set; }

        public Student(int ID, string name, string surname, string address,double gpa) : base(name, surname, address)
        {
            Gpa = gpa;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"GPA: {Gpa}");
        }
    }

    class Employee : Person
    {
        public string JobTitle;
        public Employee(int ID, string name, string surname, string address,string jobtitle) : base(name, surname, address)
        {
            JobTitle = jobtitle;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Job Title: {JobTitle}");
        }
    }
}
