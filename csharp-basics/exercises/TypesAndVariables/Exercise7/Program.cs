namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string word = "";
            Console.Write("Input word:");
            word = Console.ReadLine();
            char[] letters = word.ToCharArray();
            foreach(char ch in letters)
            {
                if (char.IsUpper(ch))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}