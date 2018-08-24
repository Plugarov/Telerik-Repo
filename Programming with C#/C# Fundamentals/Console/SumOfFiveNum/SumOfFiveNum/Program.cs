using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine()); //2
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()); //5
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());//-3
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());//-3
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());//-3

            double result = a + b + c + d + e;
            Console.WriteLine(result);
        }
    }
}
