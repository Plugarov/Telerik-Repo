using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            reverseNumber(input);
        }

        static void reverseNumber(string input)
        {
            char[] str = input.ToCharArray();
            string reversed = null;
            int len = input.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
