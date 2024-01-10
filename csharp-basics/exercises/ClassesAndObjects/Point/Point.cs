using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static void swapPoints(ref Point p1, ref Point p2){
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}
