using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        static double pi = Math.PI;

        public static double AreaOfCircle(decimal radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("ERROR: Radius must be positive!");
                return 0;
            }
            else
            {
                return pi * Math.Pow((double)radius,2);
            }        
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0)
            {
                Console.WriteLine("ERROR: Length and Width must be positive!");
                return 0;
            }
            else
            {
                return (double)(length * width);
            }
            
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if(ground<0 || h < 0)
            {
                Console.WriteLine("ERROR: Base and High must be positive!");
                return 0;
            }
            else
            {
                return (double)(ground * h)/2.0;
            } 
        }
    }
}
