using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main()
        {
            int[] n = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

            bool symetric = true;
            int startIndex = 0;
            int endIndex = n.Length - 1;

            while (startIndex < endIndex)
            {
                if (n[startIndex] != n[endIndex])
                {
                    symetric = false;
                    break;
                }
                ++startIndex;
                --endIndex;
            }

            if (symetric)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
