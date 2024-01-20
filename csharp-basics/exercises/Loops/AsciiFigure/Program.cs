namespace AsciiFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter figure size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int lineLength = (size - 1) * 8;

            for(int row = 0; row < size; row++)
            {
                string asterisksSequence = new string('*',row * 8);
                string forwardslashCount = new string('/', (lineLength - asterisksSequence.Length) / 2);
                string backslashCount=new string('\\',(lineLength-asterisksSequence.Length)/2);

                if (lineLength == 0)
                {
                    Console.Write($"{new string('/',8)}{new string('\\',8)}");
                    break;
                }

                Console.Write($"{forwardslashCount}{asterisksSequence}{backslashCount}");
                Console.WriteLine();
            }
        }
    }
}