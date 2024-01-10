namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(-3, 3);
            Point p2 = new Point(4, 9);
            Point.swapPoints(ref p1, ref p2);
            Console.WriteLine($"P1:x={p1.x} y={p1.y}");
            Console.WriteLine($"P2:x={p2.x} y={p2.y}");
        }
    }
}