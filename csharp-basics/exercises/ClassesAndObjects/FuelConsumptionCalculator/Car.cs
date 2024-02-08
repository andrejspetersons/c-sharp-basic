using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    internal class Car
    {
        public double StartOdo { get; private set; }
        public double CurrentMileage { get; private set; }
        public double Liters { get; private set; }

        public Car(double startOdo)
        {
            StartOdo = startOdo;
            Liters = 0;
            CurrentMileage = 0;
        }

        public double CalculateConsumption()
        {
            return CurrentMileage / (double)Liters;   
        }

        public bool IsGasHog()
        {
            return (decimal)CalculateConsumption() < 100M / 15;
        }

        public bool IsEconomyCar()
        {
            return (decimal)CalculateConsumption() > 100M / 5;
        }

        public void FillUp(int mileage,double liters)
        {
            double OldOdoVal = StartOdo;
            StartOdo += mileage;
            CurrentMileage = StartOdo - OldOdoVal;
            Liters+=liters;
        }
    }
}
