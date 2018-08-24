using System;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            int[] intArray = stringToIntArray(input);

            largerNeighbours(intArray);
        }

        static int[] stringToIntArray(string input)
        {
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] nums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int tmp;
                if (int.TryParse(numbers[i], out tmp))
                {
                    nums[i] = tmp;
                }
            }
            return nums;
        }

        static void largerNeighbours(int[] intArray)
        {
            int len = intArray.Length;
            int counter = 0;
            for (int i = 1; i < len - 1; i++)
            {
                if (intArray[i - 1] < intArray[i] && intArray[i] > intArray[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
