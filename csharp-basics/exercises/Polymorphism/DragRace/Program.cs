using System;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var carList = new List<ICar>
            {
                new Audi(),
                new Bmw(),
                new Lexus(),
                new Tesla(),
                new KIA(),
                new Skoda(),
            };

            for (int i = 0; i < 10; i++)
            {
                
                foreach (var car in carList)
                {
                 
                    if (i == 0)
                    {
                        car.StartEngine();
                    }
                   
                    if (i == 2 && car is ILexus lexusCar)
                    {
                        lexusCar.UseNitrousOxideEngine();
                    }
                    else
                    {
                        car.SpeedUp();
                    }

                }
                
            }

            var fastestCar = carList.OrderByDescending(car => int.Parse(car.ShowCurrentSpeed())).First();
            string fastestCarType = fastestCar.GetType().Name;
            Console.WriteLine($"Fastest car: {fastestCarType} with speed {fastestCar.ShowCurrentSpeed()}");
        }
    }
}