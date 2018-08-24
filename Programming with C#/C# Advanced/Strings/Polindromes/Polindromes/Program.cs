using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Poor Dan is in a droop".Replace(" ","").ToLower();
            CheckIsPolindrome(input);
        }

        static void CheckIsPolindrome(string str)
        {
            int i = 0;
            int y = str.Length - 1;
            bool isPolindrome = true;

            while (i < y)
            {
                if (str[i] != str[y])
                {
                    isPolindrome = false;
                    break;
                }
                i++;
                y--;
            }
            Console.WriteLine(isPolindrome);
        }

    }
}
