using System;

class FiveLargerThanNeighbours
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] intArray = stringToIntArray(input);

        firstLargerNeighbours(intArray);
    }

    static int[] stringToIntArray(string input)
    {
        string[] numbers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

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

    static void firstLargerNeighbours(int[] intArray)
    {
        int len = intArray.Length;
        int firstOccurrence = 0;
        for (int i = 1; i < len - 1; i++)
        {
            if (intArray[i - 1] < intArray[i] && intArray[i] > intArray[i + 1])
            {
                firstOccurrence = i;
                break;
            }
            else
            {
                firstOccurrence = -1;
            }
        }
        Console.WriteLine(firstOccurrence);
    }
}
