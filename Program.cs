using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DAreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = x1 - y1;
            double b = x2 - y2;
            double perimeter = 2 * (a + b);
            double area = a * b;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
