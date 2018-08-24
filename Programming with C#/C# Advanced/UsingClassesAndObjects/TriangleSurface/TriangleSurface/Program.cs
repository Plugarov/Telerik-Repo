using System;

namespace TriangleSurface
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            calculateTriangleArea(a, h);
        }

        private static void calculateTriangleArea(double sideA, double hight)
        {
            Console.WriteLine((sideA * hight) / 2);
        }
    }               
}
