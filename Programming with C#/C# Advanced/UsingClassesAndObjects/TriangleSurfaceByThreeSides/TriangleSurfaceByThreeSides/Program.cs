using System;

namespace TriangleSurface
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            calculateTriangleArea(a, b, c);
        }

        private static void calculateTriangleArea(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;
            Console.WriteLine("{0:00.00}", Math.Sqrt(s*(s-sideA)*(s-sideB)*(s-sideC)));
        }
    }
}
