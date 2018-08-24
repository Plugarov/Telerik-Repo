using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class Program
    {
        static void Main() // TODO
        {
            int pos = 5;
            int num = 5351;

            int mask = 1 << pos;
            int result = mask & num;
            int bit = result >> pos;
            int exchange = bit << 26;

            long maskP = 1 << p + i;
            long valuesP = (n & maskP) >> (p + i);
            long maskQ = 1 << q + i;
            long valuesQ = (n & maskQ) >> (q + i);
            // checking if value is 0 or 1 and doing the exchange
            if (valuesP == 1)
            {
                n = n | maskQ;
            }
            else if (valuesP == 0)
            {
                n = n & ~maskQ;
            }
            if (valuesQ == 1)
            {
                n = n | maskP;
            }
            else if (valuesQ == 0)
            {
                n = n & ~maskP;
            }
        }
    }
}
}
