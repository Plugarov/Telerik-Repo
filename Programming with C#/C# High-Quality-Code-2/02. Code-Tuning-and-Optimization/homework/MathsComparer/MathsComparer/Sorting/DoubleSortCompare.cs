namespace Comparer.Sorting
{
    using System;

    public class DoubleSortCompare : SortComparer
    {
        public DoubleSortCompare(sbyte repeatTimesToCalculateAverage, long repeatTimes)
            :base (repeatTimesToCalculateAverage,repeatTimes)
        {
        }

        public void DisplayExecutionTime(double[] arrayToSort)
        {
            Console.WriteLine(this.GetType().Name);

            CalculateExecutionTime(() =>
            {
                Array.Sort(arrayToSort);
            }, "Average time in miliseconds for Insertion  sort.");

            CalculateExecutionTime(() =>
            {
                SelectionSort(arrayToSort);
            }, "Average time in miliseconds for Selection sort.");

            CalculateExecutionTime(() =>
            {
                QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
            }, "Average time in miliseconds for Quick sort.");
        }

        static void SelectionSort(double[] a)
        {
            int n = a.Length;
            for (int x = 0; x < n; x++)
            {
                int min_index = x;
                for (int y = x; y < n; y++)
                {
                    if (a[min_index] > a[y])
                    {
                        min_index = y;
                    }
                }
                double temp = a[x];
                a[x] = a[min_index];
                a[min_index] = temp;
            }
        }

        static void InteractionSort(double[] numarray)
        {
            int max = numarray.Length;

            for (int sortExternalCounter = 1; sortExternalCounter < max; sortExternalCounter++)
            {
                int sortInternalCounter = sortExternalCounter;
                while (sortInternalCounter > 0)
                {
                    if (numarray[sortInternalCounter - 1] > numarray[sortInternalCounter])
                    {
                        double temp = numarray[sortInternalCounter - 1];
                        numarray[sortInternalCounter - 1] = numarray[sortInternalCounter];
                        numarray[sortInternalCounter] = temp;
                        sortInternalCounter--;
                    }
                    else
                        break;
                }
            }
        }

        static void QuickSort(double[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            double num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] > num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            QuickSort(a, start, i - 1);
            QuickSort(a, i + 1, end);
        }
    }
}