using System;
using System.Linq;

class BubbleSort
{
    static void Main()
    {
        int inputSize = int.Parse(Console.ReadLine());

        int[] valuesArray = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Sort(inputSize, valuesArray);
    }

    static void Sort(int size, int[] values)
    {
        int len = size;
        int temp = 0;
        for (int y = 0; y < len - 1; y++)
        {
            for (int i = 0; i < len - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    temp = values[i + 1];
                    values[i + 1] = values[i];
                    values[i] = temp;
                }
            }
        }
        Console.WriteLine(String.Join(" ", values));
    }

    static void Swap(int lhs, int rhs)
    {
        int temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}