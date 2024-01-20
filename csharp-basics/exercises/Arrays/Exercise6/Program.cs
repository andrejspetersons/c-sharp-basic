namespace Exercise6
{
    internal class Program
    {
        private static int arraySize=10;
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 101);
            }

            Array.Copy(array1, array2,arraySize);
            array1[arraySize - 1] = -7;
            Console.WriteLine("Array1: " + string.Join(" ", array1));
            Console.WriteLine("Array2: " + string.Join(" ", array2));
            Console.ReadKey();
        }
    }
}