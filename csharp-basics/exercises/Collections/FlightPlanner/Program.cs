using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Linq;
using System.Net;

namespace FlightPlanner
{
    
    class Program
    {
        private const string FileName = "flights.txt";
        private static readonly string Path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);
        private Dictionary<string, List<string>> dictOfRoutes = new Dictionary<string, List<string>>();
        private List<string> routePoints = new List<string>();

        private static void Main(string[] args) 
        {
            ConsoleKeyInfo choice;
            bool isWorking = true;
            Program flightPlanner = new Program();
            
            while (isWorking)
            {
                Console.WriteLine("What wold you like to do");
                Console.WriteLine("1.Read the file");
                Console.WriteLine("2.Display List of unique cities");
                Console.WriteLine("3.Plan the route");
                Console.WriteLine("4.Round-trip tour");
                Console.WriteLine("5.Print the trip route");
                Console.WriteLine("6.Quit");

                choice= Console.ReadKey();
                Console.WriteLine();
                int value = (int)char.GetNumericValue(choice.KeyChar);

                switch (value)
                {
                    case 1:
                        flightPlanner.ReadFile();
                        break;
                    case 2:
                        DisplayListOfCities();
                        break;
                    case 3:
                        flightPlanner.PlanTheRoute();
                        break;
                    case 4:
                        flightPlanner.RoundTrip();
                        break;
                    case 5:
                        flightPlanner.PrintRoutePoints();
                        break;
                    case 6:
                        Console.WriteLine("Program is quited");
                        isWorking = false;
                        break;      
                    default:
                        Console.WriteLine("Enter value from 1 to 6");
                        break;
                }
            }       
        }

        public void ReadFile()
        {     
            string[]routes = File.ReadAllLines(Path);
            for (int i = 0; i < routes.Length; i++)
            {
                string from = routes[i].Split("->",StringSplitOptions.TrimEntries)[0];
                Console.WriteLine(from);
                string to = routes[i].Split("->",StringSplitOptions.TrimEntries)[1];
                Console.WriteLine(to);

                if (!dictOfRoutes.ContainsKey(from))
                {
                    dictOfRoutes.Add(from, new List<string>());
                    dictOfRoutes[from].Add(to);
                }
                else
                {
                    dictOfRoutes[from].Add(to);
                }
            }

            foreach (var key in dictOfRoutes.Keys)
            {
                Console.WriteLine("City: {0} Route Available: {1}", key, string.Join(",",dictOfRoutes[key]));
            }
        }

        public static void DisplayListOfCities()//display complete list of city?
        {      
            string[]routes = File.ReadAllLines(Path);
            List<string> cities = new List<string>();
            
            for (int i = 0; i < routes.Length; i++)
            {
                string[] splitCities = routes[i].Split("->",StringSplitOptions.TrimEntries);

                for(int j = 0; j < splitCities.Length; j++)
                {
                    cities.Add(splitCities[j]);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,cities.Distinct().OrderBy(str=>str)));
        }

        public void PlanTheRoute()
        {
            bool TripContinue = true;

            while (TripContinue)
            {
                if (routePoints.Count == 0)
                {
                    Console.WriteLine("\nEnter the city as start of trip:");
                }
                else
                {
                    Console.WriteLine("\nEnter the next city:");
                }
                
                string city = Console.ReadLine();

                if (string.IsNullOrEmpty(city))
                {
                    Console.WriteLine("End of the trip");
                    TripContinue = false;
                }
                else
                {
                    if (dictOfRoutes.ContainsKey(city))
                    {
                        Console.WriteLine("\nCities that can be reached directly:");

                        foreach (var item in dictOfRoutes[city])
                        {
                            Console.WriteLine(item);
                        }

                        routePoints.Add(city);
                    }
                    else
                    {
                        Console.WriteLine("\nNo such key in directory");
                    }
                }
                
            }
        }

        public void RoundTrip()
        {
            bool TripContinue=true;

            while (TripContinue)
            {
                if (routePoints.Count == 0)
                {
                    Console.WriteLine("\nEnter the city as start of trip:");
                }
                else
                {
                    Console.WriteLine("\nEnter the next city:");
                }

                string city = Console.ReadLine();

                if (routePoints.Count > 0 && routePoints.ElementAt(0) == city)
                {
                    routePoints.Add(city);
                    Console.WriteLine("End of the trip");
                    Console.WriteLine(string.Join("->", routePoints));
                    break;
                }

                if (string.IsNullOrEmpty(city))
                {
                    Console.WriteLine("End of the trip");
                    TripContinue = false;
                }
                else
                {
                    if (dictOfRoutes.ContainsKey(city))
                    {
                        Console.WriteLine("\nCities that can be reached directly:");

                        foreach (var item in dictOfRoutes[city])
                        {
                            Console.WriteLine(item);
                        }

                        routePoints.Add(city);
                    }
                    else
                    {
                        Console.WriteLine("\nNo such key in directory");
                    }
                }
            }
        }

        public void PrintRoutePoints()
        {
                Console.WriteLine(string.Join("->",routePoints));
                routePoints.Clear();
        }
    }
}