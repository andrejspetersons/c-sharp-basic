using System.Reflection.Metadata.Ecma335;

namespace PrintDayInWord
{
    internal class Program
    {
        public static string DayToWord(int day)
        {
            string result;
            switch (day)
            {
                case 1:
                    result = "Monday";
                    break;
                case 2:
                    result = "Tuesday";
                    break;
                case 3:
                    result = "Wednesday";
                    break;
                case 4:
                    result = "Thursday";
                    break;
                case 5:
                    result = "Friday";
                    break;
                case 6:
                    result = "Saturday";
                    break;
                case 7:
                    result = "Sunday";
                    break;
                default:
                    result = "Not a valid day";
                    break;
            }
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input day Number:");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            string result = DayToWord(dayNumber);
            Console.WriteLine(result);
        }
    }
}