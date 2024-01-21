namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1= new Student(1, "Andrejs", "Petersons", "XXXX iela", 7.3);
            student1.display();

            Console.WriteLine();

            Employee employee = new Employee(1, "John", "Abel", "Green St", "Front-End Developer");
            employee.display();
        }
    }
}