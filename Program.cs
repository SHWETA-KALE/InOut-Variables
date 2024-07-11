using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area(out double length, out double width, out double rarea);
            Console.WriteLine("The Length of the rectangle is " + length);
            Console.WriteLine("The Width of the rectangle is " + width);
            Console.WriteLine("The Area of the rectangle is " + rarea);

            Perimeter(out int a, out int b, out int perimeterR);
            Console.WriteLine("The Perimeter of the rectangle is " + perimeterR);
        }

        static void Area(out double l, out double w, out double area)
        {
            l = 50; w = 50;
            area = l * w;

        }

        static void Perimeter(out int a, out int b, out int perimeterR)
        {
            a = 20; b = 3;
            perimeterR = 2*a+2*b;
        }
    }
}
