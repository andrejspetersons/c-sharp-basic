namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            string result="";
            
            while (input.Length != 1)
            {
                char[] ch = input.ToCharArray();
                int sum = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (char.IsDigit(ch[i]))
                    {
                        sum += (int)Math.Pow(char.GetNumericValue(ch[i]), 2);
                        
                    }
                }

                if (sum == 1)
                {
                    result = "Is happy!";
                }
                if (sum > 1 && sum <= 9)
                {
                    result = "Not happy!";
                }

                Console.WriteLine(sum);
                input = new string(sum.ToString());
            }

            Console.WriteLine(result);
        }
    }
}