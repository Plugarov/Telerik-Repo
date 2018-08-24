using System;

namespace StringLength
{
    class Program
    {
        static void Main()
        {
            string input = "Hello World";
            FillEmpty(input);
        }

        static void FillEmpty(string str)
        {
            string result = str.PadRight(str.Length + 20, '*');
            Console.WriteLine(result);
        }
    }
}
