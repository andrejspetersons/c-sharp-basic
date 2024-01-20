using System.Globalization;

namespace Exercise8
{
    internal class Program
    {
        public static void TotalPay(double basePay,int hoursWorked)
        {
            double totalPay;
            int standardWorkHours = 40;

            if(hoursWorked>60 || basePay < 8.00)
            {
                Console.WriteLine("Error in data");
                return;
            }
            else if(hoursWorked>40 && hoursWorked<60)
            {
                totalPay = basePay*standardWorkHours + (hoursWorked - standardWorkHours) * basePay * 1.5;
                Console.WriteLine($"Total pay = {Math.Round(totalPay,2)}");
            }
            else if(hoursWorked>0 && hoursWorked <= 40)
            {
                totalPay = basePay * hoursWorked;
                Console.WriteLine($"Total pay = {Math.Round(totalPay,2)}");
            }
        }

        static void Main(string[] args)
        {
            string basePayInput;

            Console.WriteLine("Enter data for Employee1");

            Console.Write("base pay = ");          
            basePayInput = Console.ReadLine();
            double basePay1 = Convert.ToDouble(basePayInput, CultureInfo.InvariantCulture);
            Console.Write("hours worked = ");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter data for Employee2");

            Console.Write("base pay = ");
            basePayInput = Console.ReadLine();
            double basePay2 = Convert.ToDouble(basePayInput,CultureInfo.InvariantCulture);
            Console.Write("hours worked = ");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter data for Employee3");

            Console.Write("base pay = ");
            basePayInput = Console.ReadLine();
            double basePay3 = Convert.ToDouble(basePayInput,CultureInfo.InvariantCulture);
            Console.Write("hours worked = ");
            int hoursWorked3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Employee1 with base pay {basePay1} and {hoursWorked1}");
            TotalPay(basePay1, hoursWorked1);
            Console.WriteLine($"Employee2 with base pay {basePay2} and {hoursWorked2}");
            TotalPay(basePay2, hoursWorked2);
            Console.WriteLine($"Employee3 with base pay {basePay3} and {hoursWorked3}");
            TotalPay(basePay3, hoursWorked3);
        }
    }
}