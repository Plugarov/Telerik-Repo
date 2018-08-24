using System;
using System.Collections.Generic;
//TODO

namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int start;
            int end;

            start = LoopUntilIntegerIsEntered("Please enter START range number.");
            end = LoopUntilIntegerIsEntered("Please enter END range number.");

            ReadNumber(start, end);
        }

        static void ReadNumber(int start, int end)
        {
            int num1 = start;
            int num2;

            List<int> result = new List<int>();

            try
            {
                if (end - start < 9)
                {
                    throw new Exception("Range should be at least 10");
                }

                int i = 0;
                while (i < 10)
                {
                    num2 = LoopUntilIntegerIsEntered("Please enter number");

                    if (num1 <= num2 && num1 >= start && num2 <= end)
                    {
                        result.Add(num2);
                        num1 = num2;
                        i++;
                    }
                    else
                    {
                        throw new Exception("Out of range");
                    }
                }
                Console.WriteLine("{0}", string.Join(" < ", result));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// This method loops ReadLine() until user enters integer value. 
        /// </summary>
        /// <param name="message">This message is printed until user enter correct value</param>
        /// <returns>integer value</returns>
        static int LoopUntilIntegerIsEntered(string message)
        {
            int number;
            bool check;
            do
            {
                Console.WriteLine(message);
                check = int.TryParse(Console.ReadLine(), out number);
            }
            while (!check);

            return number;
        }

    }
}
