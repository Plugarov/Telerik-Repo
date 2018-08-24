using System;
using System.Linq;

namespace AppearanceCount
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] intArray = stringToIntArray(input);
            Counter(intArray, 5);
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

        static void Counter(int[] nums, int numToSearch)
        {
            var numQuery = from num in nums where num == numToSearch select num;

            int counter = 0;
            foreach (int num in numQuery)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
