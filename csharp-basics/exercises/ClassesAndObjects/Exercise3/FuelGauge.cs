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
        public double Litrs;
        public double CurrentMileage;
        public Odometer Odometer;
        public FuelGauge FuelGauge;
        
        public Car()
        {
            Litrs = 0;
            CurrentMileage = 0;
            Odometer = new(this);
            FuelGauge = new(this);
        }

    }

    internal class FuelGauge
    {
        public Car Car;

        public FuelGauge(Car car)
        {
            Car = car;
        }

        public double GetCurrentFuel()
        {
            return Car.Litrs;
        }

        public string GetFuelReport()
        {
            return $"Current amount of fuel:{Car.Litrs}";
        }

        public void PutFuel(double liters)
        {
            if (Car.Litrs >= 70||liters>70)
            {
                Car.Litrs = 70;
            }
            else
            {
                Car.Litrs += liters;
            }
        }

        public void FuelBurn()
        {
            if (Car.Litrs <= 0)
            {
                Console.WriteLine($"Fuel is zero");
                return;
            }
            else
            {
                Car.Litrs -= 1;
            }
        }
    }

    internal class Odometer
    {
        public Car Car;
        public FuelGauge FuelGauge;
        public double CurrentMileage;

        public Odometer(Car car)
        {
            Car = car;
            FuelGauge = new FuelGauge(Car);
        }

        public double GetCurrentMileage()
        {
            return Car.CurrentMileage;
        }

        public string GetMileageReport()
        {
            return $"Current Mileage:{Car.CurrentMileage}";
        }

        public void IncreaseMileage()
        {
            Car.CurrentMileage += 1;

            if (Car.CurrentMileage > 999999)
            {
                Car.CurrentMileage = 0;
            }
            else if(Car.CurrentMileage%10==0)
            {
                 FuelGauge.FuelBurn();
            }    
        }
    }
}
