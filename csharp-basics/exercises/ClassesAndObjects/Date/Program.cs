using System;
using System.Globalization;

namespace Date
{
    internal class Program
    {
        public static string WeekdayInDutch(int year,int month,int day)
        {
            var cultureInfo = new CultureInfo("nl-NL");
            var dataString = $"{year}-{month}-{day}";
            var dateTime = DateTime.ParseExact(dataString, "yyyy/M/d", cultureInfo);
            var dayName = cultureInfo.DateTimeFormat.GetDayName(dateTime.DayOfWeek).ToString();
            return dayName;          
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WeekdayInDutch(2001, 9, 11));
        }
    }
}