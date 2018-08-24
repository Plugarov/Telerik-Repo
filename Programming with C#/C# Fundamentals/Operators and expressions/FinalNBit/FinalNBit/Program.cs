using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalNBit
{
    class Program
    {
        static void Main()
        {

            int pos = 0; // 0010 0000
            int num = 5; // 0010 0011

            int mask = 1 << pos;
            int maskAndNum = mask & num;
            int bit = maskAndNum >> pos;

            Console.WriteLine("the bit on position {1} of number {0} is : {2} ", pos, num, bit);
            Console.WriteLine(
                Convert.ToString(num, 2).PadLeft(8, '0')
            );
        }
    }
}
