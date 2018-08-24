using System;

namespace ShadowCopy
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = (int[])arr.Clone();
            arr[1] = 5;

            Console.WriteLine(arr[1]);
            Console.WriteLine(arr2[1]);
        }
    }
}
