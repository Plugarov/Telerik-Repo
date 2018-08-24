namespace Comparer.Sorting
{
    using System;

    public class StringSortCompare : SortComparer
    {
        public StringSortCompare(sbyte repeatTimesToCalculateAverage, long repeatTimes)
            : base(repeatTimesToCalculateAverage, repeatTimes)
        {
        }

        public void DisplayExecutionTime(string[] arrayToSort)
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
                Quicksort(arrayToSort, 0, arrayToSort.Length - 1);
            }, "Average time in miliseconds for Quick sort.");
        }

        public static void SelectionSort(string[] ar)
        {
            int n = ar.Length;
            for (int x = 0; x < n; x++)
            {
                int min_index = x;
                for (int y = x; y < n; y++)
                {
                    if (ar[min_index].CompareTo(ar[y]) > 0)
                    {
                        min_index = y;
                    }
                }
                string temp = ar[x];
                ar[x] = ar[min_index];
                ar[min_index] = temp;
            }
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}