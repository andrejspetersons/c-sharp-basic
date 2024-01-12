namespace Exercise3
{
    internal class Program
    {
        public static int[] GenerateNumbers(int size)
        {
            Random random = new Random();
            int[] arrayNumbers = new int[size];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.Next(1, 101);
            }

            return arrayNumbers;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numberArray = GenerateNumbers(size);
            int pos;

            while (true)
            {
                Console.WriteLine("Enter number position you want to know");
                
                if(int.TryParse(Console.ReadLine(),out pos) && pos < size && pos >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.Please enter another value");
                }

            }

            int result = numberArray[pos];
            Console.WriteLine("Result: "+result);
        }
    }
}
