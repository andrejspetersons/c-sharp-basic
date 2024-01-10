namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.odometer = new Odometer(car);
            car.fuelGauge = new FuelGauge(car);
            car.fuelGauge.PutFuel(70);
            Console.WriteLine($"Fuel={car.litrs}");

            while (car.litrs > 0)
            {
                car.odometer.increaseMileage();
                car.litrs = car.fuelGauge.GetCurrentFuel();
                
            }
            Console.WriteLine(car.odometer.GetCurrentMileage());
        }
    }
}