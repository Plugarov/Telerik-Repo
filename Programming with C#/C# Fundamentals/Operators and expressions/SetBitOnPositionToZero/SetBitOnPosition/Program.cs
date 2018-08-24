using System;

namespace SetBitOnPosition
{
    class Program
    {
        static void Main()
        {

            int n = 4;  // 0000 0110
            int p = 35; // 0010 0010
                        // 1000 1000
                        // 0111 0111

            int mask = ~(1 << n);
            int newNum = (p & mask);

            Console.WriteLine(newNum);
        }
    }
}
