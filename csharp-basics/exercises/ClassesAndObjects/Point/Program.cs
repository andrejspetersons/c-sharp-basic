namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(-3, 3);
            Point p2 = new Point(4, 9);
            swapPoints(ref p1, ref p2);
            Console.WriteLine($"P1:x={p1.x} y={p1.y}");
            Console.WriteLine($"P2:x={p2.x} y={p2.y}");
        }

        public static void swapPoints(ref Point p1, ref Point p2)
        {
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}