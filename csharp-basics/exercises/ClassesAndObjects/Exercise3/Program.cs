namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Odometer = new Odometer(car);
            car.FuelGauge = new FuelGauge(car);
            car.FuelGauge.PutFuel(70);
            Console.WriteLine($"Fuel={car.Litrs}");

            while (car.Litrs > 0)
            {
                car.Odometer.IncreaseMileage();
                car.Litrs = car.FuelGauge.GetCurrentFuel();
                
            }

            Console.WriteLine(car.Odometer.GetCurrentMileage());
        }
    }
}