namespace Exercise10
{
    internal class Program
    {
        public static int[] CountPosSumNeg(int[] numbers)
        {
            int sumNegative = 0;
            int countPositive = 0;

            if (numbers.Length == 0)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    countPositive++;
                }
                else
                {
                    sumNegative+=numbers[i];
                }
            }

            return new int[] { countPositive, sumNegative };
        }
        
        static void Main(string[] args)
        {
            int[] arrNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] emptyArray = Array.Empty<int>();
            int[] result1 = CountPosSumNeg(arrNumbers);
            int[] result2 = CountPosSumNeg(emptyArray);
            Console.WriteLine("[" + string.Join(",", result1) + "]");
            Console.WriteLine("[" + string.Join(",", result2) + "]");


        }
    }
}
