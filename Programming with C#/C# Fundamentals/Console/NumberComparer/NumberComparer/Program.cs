using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a < b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("equal");
            }
        }
    }
}
