namespace Exercise9
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //S=Vt
            int distance,hours,minutes,seconds;
            
            Console.WriteLine("Test Data");

            Console.Write("Input distance in meters:");
            string distanceInput = Console.ReadLine();
            distance = int.Parse(distanceInput);

            
            Console.Write("Input hour:");
            string hoursInput = Console.ReadLine();
            hours = int.Parse(hoursInput);

            Console.Write("Input minutes:");
            string minutesInput = Console.ReadLine();
            minutes = int.Parse(minutesInput);

            Console.Write("Input seconds:");
            string secondsInput=Console.ReadLine();
            seconds = int.Parse(secondsInput);



            double result1 = Math.Round(distance / (hours * 3600.0 + minutes * 60.0 + seconds),8); //m/s
            double result2 = Math.Round(distance/1000.0/(hours+(minutes/60.0)+(seconds/3600.0)),8); //km/h
            double result3 = Math.Round(result2 / 1.609,8); //miles/h
            


            Console.WriteLine($"Your speed in meters/second is {result1}");
            Console.WriteLine($"Your speed in km/h is {result2}");
            Console.WriteLine($"Your speed in miles/h is {result3}");

        }
    }
}