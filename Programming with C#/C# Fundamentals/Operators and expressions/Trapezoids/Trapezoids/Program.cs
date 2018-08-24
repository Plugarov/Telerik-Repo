using System;

namespace Trapezoids
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a b sides and height");
            string input = Console.ReadLine();

            string[] arg = input.Split(new string[] { " " }, StringSplitOptions.None);

            double sideA = Double.Parse(arg[0]);
            double sideB = Double.Parse(arg[1]);
            double height = Double.Parse(arg[2]);
            double result = ((sideB + sideA) / 2) * height;

            Console.WriteLine("The area is : " + "{0:0.0000000}", result);
        }
    }
}
