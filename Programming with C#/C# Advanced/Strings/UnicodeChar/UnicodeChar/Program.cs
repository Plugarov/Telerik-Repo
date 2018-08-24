using System;
using System.Text;

namespace UnicodeChar
{
    class Program
    {
        static void Main()
        {
            string input = "Hello";
            ConvertToUnicode(input);
        }

        static void ConvertToUnicode(string str)
        {

            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
                sb.AppendFormat("\\u{0:X4}", (uint)c);
            Console.WriteLine(sb.ToString());


        }
    }
}
