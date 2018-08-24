using System;

namespace FourDigits
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            double sum = 0;
            string reverse = "";

            for (int i = 0; i < 4; i++)
            {
                sum += Char.GetNumericValue(input[i]);
            }

            for (int i = 3; i >= 0; i--)
            {
                reverse += input[i];
            }

            char tmp = input[1];
            input = input.Remove(1, 1).Insert(1, input[2].ToString());
            input = input.Remove(2, 1).Insert(2, tmp.ToString());

            Console.WriteLine(sum);
            Console.WriteLine(reverse);
            Console.WriteLine(input);
        }
    }
}
