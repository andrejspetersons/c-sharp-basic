namespace FindTheNemoInText
{
    internal class Program
    {
        public static int FindNemo(string text)
        {
            int indexOfNemo = -1;
            string[] words = text.Split(" ");

            for (int i = 0; i <words.Length; i++)
            {
                if (words[i] == "Nemo")
                {
                    indexOfNemo = i;
                    return indexOfNemo;
                }  
            }

            return indexOfNemo;
        }
        static void Main(string[] args)
        {
            int resultPos1 = FindNemo("I am finding Nemo !");
            int resultPos2 = FindNemo("Nemo is me");
            int resultPos3 = FindNemo("I Nemo am");

            if (resultPos3 != -1)
            {
                Console.WriteLine($"I found Nemo at {resultPos3 + 1}!");
            }
            else
            {
                Console.WriteLine("I can't find Nemo :(");
            }
        }
    }
}