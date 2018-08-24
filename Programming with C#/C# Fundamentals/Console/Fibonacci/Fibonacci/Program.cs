using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            int len = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;

            for (int i = 1; i <= len; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(b);
            }
        }
    }
}
