using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsNotDriven;
            double seatsInACar, carpoolCapacity, averagePasPerCar;

            cars = 100; 
            seatsInACar = 4; 
            drivers = 28; 
            passengers = 90;
            carsNotDriven = cars - drivers;
            carpoolCapacity = drivers * (seatsInACar - 1);
            averagePasPerCar = Math.Round(passengers / (double)drivers,0);

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePasPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}