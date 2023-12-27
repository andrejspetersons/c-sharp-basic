using System.Text.RegularExpressions;

namespace BMI
{
    internal class Program
    {
        static string ClearNumber(string inputNumber)
        {
            string pattern = "[^0-9.]";
            string clearNumber = Regex.Replace(inputNumber, pattern, "");
            return clearNumber;
        }

        static void Main(string[] args)
        {
            string weightInput, heightInput;
            Console.WriteLine("Input data to calculate your BMI");

            Console.Write("Enter weight(in pounds):");
            weightInput = ClearNumber(Console.ReadLine());
            int weight = Convert.ToInt32(weightInput);
           
            

            Console.Write("Enter height(in inches):");
            heightInput = ClearNumber(Console.ReadLine());
            int height = Convert.ToInt32(heightInput);

            
            double BMI = weight * 703 / (double)Math.Pow(height, 2);
           
            

            Console.WriteLine($"Your height = {height} inches\nYour weight = {weight} pounds\nYour BMI = {BMI}");

            
            if (BMI < 18.5)
            {
                Console.WriteLine("You are underweight");
            }
            else if (BMI>18.5 && BMI < 25.0)
            {
                Console.WriteLine("Congratulation!Your BMI is optimal");
            }
            else
            {
                Console.WriteLine("You are overweight");
            }


        }
    }
}