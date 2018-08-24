using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

    class Task1
    {
        static void Main(string[] args)
        {
            string[] digit = { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };
            string line = Console.ReadLine();

            for (int i = digit.Length - 1; i >= 0; i--)
            {
                line = line.Replace(digit[i], i.ToString());
            }

            string[] numbersLine = line.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            ulong[] numbers = new ulong[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ConvertToDecimal(numbersLine[i], 8);
            }
            ulong result = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            Console.WriteLine(result);
        }

        static ulong ConvertToDecimal(string n, ushort b)
        {
            ulong result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int digit;
                if (n[i] >= '0' && n[i] <= '9')
                {
                    digit = n[i] - '0';
                }
                else
                {
                    digit = n[i] - 'A' + 10;
                }

                result = result * b + (uint)digit;
            }
            return result;
        }
    }
}