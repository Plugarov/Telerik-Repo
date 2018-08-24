using System;

namespace NBit
{
    class Program
    {
        static void Main()
        {
            int pos = 4;
            int num = 16; // 0001 0000

            int mask = 1 << pos;
            int numAndMask = num & mask; //   mask16
            int bit = numAndMask >> pos;

            Console.WriteLine("for {0} bit at position {1} is {2}", num, pos, bit);
        }
    }
}
