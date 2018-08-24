using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class Program
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());

            Console.WriteLine((Digit)(inputNum % 10));

            // or

            GetLastDigit(inputNum);

        }

        public enum Digit
        {
            zero = 0,
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9
        }

        static void GetLastDigit(int num)
        {
            string lastDigit = num.ToString();
            string digitAsWord = null;

            switch (lastDigit[lastDigit.Length - 1])
            {
                case '0': digitAsWord = "zero"; break;
                case '1': digitAsWord = "one"; break;
                case '2': digitAsWord = "two"; break;
                case '3': digitAsWord = "three"; break;
                case '4': digitAsWord = "four"; break;
                case '5': digitAsWord = "five"; break;
                case '6': digitAsWord = "six"; break;
                case '7': digitAsWord = "seven"; break;
                case '8': digitAsWord = "eight"; break;
                case '9': digitAsWord = "nine"; break;
            }

            Console.WriteLine(digitAsWord);
        }
    }
}
