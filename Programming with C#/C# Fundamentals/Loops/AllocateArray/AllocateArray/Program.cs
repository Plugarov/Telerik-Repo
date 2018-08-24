using System;

namespace AllocateArray
{
    class Program
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
		for(int i = 0; i<n; i++) {
			arr[i] = i* 5;
		}
		for(int j = 0; j<n; j++) {
			Console.WriteLine(arr[j]);
		}
    }
}
