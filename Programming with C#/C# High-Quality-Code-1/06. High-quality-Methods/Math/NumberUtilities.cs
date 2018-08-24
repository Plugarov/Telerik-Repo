namespace Math
{
    using System;

    public class NumberUtilities
    {
        private static readonly string[] digitNames =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        static string NumberToDigit(int number)
        {
            if (0 < number || number > 9)
            {
                throw new ArgumentOutOfRangeException("Number must be between 0 and 9.");
            }

            return this.digitNames[number];
        }

        public static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintWithFixedPoint(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintWithRightAlignment(object number)
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}
