namespace Assertions
{
    using System;
    using System.Linq;
    using System.Diagnostics;

    class SearchingAlgorithms
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Arr is empty."); 
            Debug.Assert(arr != null, "Arr is null."); 
            Debug.Assert(value != null, "value is null.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
            where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Arr is empty."); 
            Debug.Assert(arr != null, "Arr is null."); 
            Debug.Assert(value != null, "value is null.");
            Debug.Assert(startIndex <= endIndex, "start index should be smaller than end index.")
            Debug.Assert(startIndex < arr.Length, "start index should be smaller than array length.")
            Debug.Assert(endIndex < arr.Length, "end index should be smaller than array length.")
            Debug.Assert(startIndex >= 0, "start index should be bigger or equal to 0.")
            Debug.Assert(endIndex >= 0, "end index should be bigger or equal to 0.")

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else 
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}