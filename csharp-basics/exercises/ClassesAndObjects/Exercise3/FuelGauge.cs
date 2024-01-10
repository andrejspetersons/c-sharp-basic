using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Car
    {
        public double litrs;
        public double currentMileage;
        public Odometer odometer;
        public FuelGauge fuelGauge;
        
        public Car()
        {
            litrs = 0;
            currentMileage = 0;
            odometer = new(this);
            fuelGauge = new(this);
        }

    }

    internal class FuelGauge
    {
        public Car car;

        public FuelGauge(Car car)
        {
            this.car = car;
        }

        public double GetCurrentFuel()
        {
            return car.litrs;
        }

        public string GetFuelReport()
        {
            return $"Current amount of fuel:{car.litrs}";
        }

        public void PutFuel(double liters)
        {
            if (car.litrs >= 70||liters>70)
            {
                car.litrs = 70;
            }
            else
            {
                car.litrs += liters;
            }
        }

        public void FuelBurn()
        {
            if (car.litrs <= 0)
            {
                Console.WriteLine($"Fuel is zero");
                return;
            }
            else
            {
                car.litrs -= 1;
            }
        }
    }

    internal class Odometer
    {
        public Car car;
        public FuelGauge fuelgauge;

        public Odometer(Car car)
        {
            this.car = car;
            fuelgauge = new FuelGauge(this.car);
        }

        public double currentMileage;

        public double GetCurrentMileage()
        {
            return car.currentMileage;
        }

        public double GetMileageReport()
        {
            return car.currentMileage;
        }

        public void increaseMileage()
        {
            car.currentMileage += 1;
            if (car.currentMileage > 999999)
            {
                car.currentMileage = 0;
            }
            else if(car.currentMileage%10==0)
            {

                 fuelgauge.FuelBurn();
            }
            
        }


    }

    
}
