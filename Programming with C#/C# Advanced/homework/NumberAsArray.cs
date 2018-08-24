using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        static void Main()
        {
            // Input
            int[] sizes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string firstNumDigits = Console.ReadLine()
                .Replace(" ", string.Empty);

            string secondNumDigits = Console.ReadLine()
                .Replace(" ", string.Empty);


            int biggerNum = Math.Max(sizes[0], sizes[1]);
            int smallerNum = Math.Min(sizes[0], sizes[1]); ;

            string biggerArray;
            string smallerArray;

            if (biggerNum == sizes[0])
            {
                biggerArray = firstNumDigits;
                smallerArray = secondNumDigits;
            }
            else
            {
                biggerArray = secondNumDigits;
                smallerArray = firstNumDigits;
            }

            AddingTwoNumbersDigits(smallerArray, biggerArray, smallerNum, biggerNum);
        }

        private static void AddingTwoNumbersDigits(string smallerArray, string biggerArray,
        int smallerNum, int biggerNum)
        {
            int remainder = 0;
            int result = 0;
            List<int> sumNumsDigits = new List<int>();
            for (int i = 0; i < smallerNum; i++)
            {
                result = (int)biggerArray[i] - '0' + (int)smallerArray[i] - '0' + remainder;
                if (result < 10)
                {
                    sumNumsDigits.Add(result);
                    remainder = 0;
                }
                else
                {
                    sumNumsDigits.Add(result % 10);
                    remainder = result / 10;
                }
            }

            for (int i = smallerNum; i < biggerNum; i++)
            {
                result = (int)biggerArray[i] - '0' + remainder;
                if (result < 10)
                {
                    sumNumsDigits.Add(result);
                    remainder = 0;
                }
                else
                {
                    sumNumsDigits.Add(result % 10);
                    remainder = result / 10;
                }
            }

            if (remainder > 0)
            {
                sumNumsDigits.Add(remainder);
            }

            Console.WriteLine(String.Join(" ", sumNumsDigits));
        }
    }
}
