using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
             Program survey = new Program();
             double energyDrinkers = survey.CalculateEnergyDrinkers(NumberedSurveyed);
             double preferCitrus = survey.CalculatePreferCitrus(NumberedSurveyed);
             Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
             Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
             Console.WriteLine(preferCitrus + " of those " + "prefer citrus flavored energy drinks.");
        }

        double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return Math.Floor(numberSurveyed * PurchasedEnergyDrinks);
        }

        double CalculatePreferCitrus(int numberSurveyed)
        {
            return Math.Floor(CalculateEnergyDrinkers(numberSurveyed) * PreferCitrusDrinks);
        }
    }
}
