using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetterss
{
    class Program
    {
        static void Main()
        {
            string input = "aaaaabbbbbfffcdddeeeedssaaatttt";
            SeriesOfLetters(input);
        }

        static void SeriesOfLetters(string input)
        {
            StringBuilder result = new StringBuilder();
            string str = input;

            result.Append(str[0]);

            int len = str.Length - 1;
            for (int i = 1; i < len; i++)
            {
                if (str[i - 1] != str[i])
                {
                    result.Append(str[i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
