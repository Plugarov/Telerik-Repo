using System;

namespace NFactorial
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int.TryParse(input , out int n);

            NFactorial(n);
        }
        static void NFactorial(int n)
        {
            int len = n;
            int result = 1;
            int multiplyer;
            for (int i = 1; i < n; i++)
            {
                multiplyer = i + 1;
                result *= multiplyer;
            }
            Console.WriteLine(result);
        }
    }
}
