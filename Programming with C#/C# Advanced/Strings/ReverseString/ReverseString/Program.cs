using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStr
{
    class Program
    {
        static void Main()
        {
            string str = "Has to be reversed";

            ReverseString(str);
        }

        static void ReverseString(string str)
        {
            StringBuilder reversed = new StringBuilder();

            int len = str.Length - 1;
            for (int i = len; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
