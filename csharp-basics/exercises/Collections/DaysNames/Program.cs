﻿// See https://aka.ms/new-console-template for more information
//ToDo: Write a query that returns names of days
//https://docs.microsoft.com/en-us/dotnet/api/system.dayofweek?view=net-6.0

class DaysNames
{
    static void Main(string[] args)
    {
        string[] dw = Enum.GetNames(typeof(DayOfWeek));
        Console.WriteLine(string.Join(",",dw.Select(x=>x)));
    }
}
