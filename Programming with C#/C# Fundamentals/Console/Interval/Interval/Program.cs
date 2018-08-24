using System;

namespace Interval
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int difference = (b - a) / 5;

            Console.WriteLine(difference);
        }
    }
}
