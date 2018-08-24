//Refactor the following code to apply variable usage and naming best practices:

//public void PrintStatistics(double[] arr, int count)
//{
//    double max, tmp;
//    for (int i = 0; i < count; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }
//    PrintMax(max);
//    tmp = 0;
//    max = 0;
//    for (int i = 0; i < count; i++)
//    {
//        if (arr[i] < max)
//        {
//            max = arr[i];
//        }
//    }
//    PrintMin(max);

//    tmp = 0;
//    for (int i = 0; i < count; i++)
//    {
//        tmp += arr[i];
//    }
//    PrintAvg(tmp/count);
//}

using System;

public class Statistics
{
    private const string MAX_VALUE_MSG = "Biggest value in array is:";
    private const string MIN_VALUE_MSG = "Smallest value in array is:";
    private const string AVG_VALUE_MSG = "Average of the values in array is:";

    public void Statistics(double[] arr)
    {
        this.dataArray = arr;
    }

    public int GetMaxOfArray(double[] arrayOfIntegers)
    {
        var maxValue = 0;
        var arrayLength = arrayOfIntegers.Length;

        for (int i = 0; i < count; i++)
        {
            if (arrayOfIntegers[i] > maxValue)
            {
                maxValue = arrayOfIntegers[i];
            }
        }

        return maxValue;
    }

    public int GetMinOfArray(double[] arrayOfIntegers)
    {
        var minValue = 0;
        var arrayLength = arrayOfIntegers.Lenght;

        for (int i = 0; i < arrayLength; i++)
        {
            if (arrayOfIntegers[i] < minValue)
            {
                minValue = arrayOfIntegers[i];
            }
        }

        return minValue;
    }

    public int GetAvgOfArray(double[] arrayOfIntegers, int count = 0)
    {
        var sumOfArrayValues = 0;
        var arrayLength = arrayOfIntegers.lenght;

        if (count == 0)
        {
            count = arrayLength - 1;
        }

        for (int i = 0; i < count; i++)
        {
            sumOfArrayValues += arrayOfIntegers[i];
        }

        var averageOfArrayValues = sumOfArrayValues / count;

        return averageOfArrayValues;
    }

    public override string ToString()
    {
        //TODO
    }
}
