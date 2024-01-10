using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car testCar1 = new Car(200);
            Car testCar2 = new Car(200);

            testCar1.FillUp(50, 2);
            testCar2.FillUp(50, 1);

            double result1 = testCar1.CalculateConsumption();
            double result2 = testCar2.CalculateConsumption();


            Console.WriteLine($"Fuel Consumption: {result1}\n" + $"Economy car: {testCar1.IsEconomyCar()}\n" + $"Hog Car {testCar1.IsGasHog()}\n");
            Console.WriteLine($"Fuel Consumption: {result2}\n" + $"Economy car: {testCar2.IsEconomyCar()}\n" + $"Hog Car {testCar2.IsGasHog()}\n");


        }
    }
}
