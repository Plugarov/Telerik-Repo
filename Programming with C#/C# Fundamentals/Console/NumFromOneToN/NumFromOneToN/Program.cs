using System;

namespace NumFromOneToN
{
    class Program
    {
        static void Main()
        {
            Console.Write("num = ");
            double a = double.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
