using System;
using System.Collections.Generic;

namespace RemoveFromArray
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>();

            for (int i = 0; i < 30; i++)
            {
                intList.Add(i);
            }
            intList.RemoveAt(3);
            Console.WriteLine(String.Join(" ", intList));
        }
    }
}
