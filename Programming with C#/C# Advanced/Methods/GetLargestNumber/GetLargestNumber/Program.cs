using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] nums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int tmp;
            if (int.TryParse(numbers[i], out tmp))
            {
                nums[i] = tmp;
            }
        }

        int maximumNum = GetMax(GetMax(nums[0], nums[1]), nums[2]);
        Console.WriteLine(maximumNum);

    }

    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


    // int[] numbers = Console.ReadLine()
    //       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    //       .Select(int.Parse)
    //       .ToArray();
}
