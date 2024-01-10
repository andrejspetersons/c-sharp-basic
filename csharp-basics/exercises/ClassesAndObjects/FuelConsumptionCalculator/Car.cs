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
        public double startOdo { get; private set; }
        public double currentMileage;
        public double liters { get; private set; }

        public Car(double startOdo)
        {
            this.startOdo = startOdo;
            liters = 0;
            currentMileage = 0;
        }

        public double CalculateConsumption()
        {
            return currentMileage / (double)liters;   
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
            double OldOdoVal = this.startOdo;
            startOdo += mileage;
            currentMileage = startOdo - OldOdoVal;
            this.liters+=liters;
        }

    }
}
