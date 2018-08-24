using System;

namespace ThirdDigit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int inputLen = input.Length;

            if (inputLen >= 3)
            {
                int number = input[inputLen - 3] - '0';
                if (number == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false" + number);
                }
            }
        }
    }
}
