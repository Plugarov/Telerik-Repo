using System;
using System.Linq;

namespace OrderWord
{
    class Program
    {
        static void Main()
        {
            string input = "One Two Three Apple Four Five";

            OrderWords(input);
        }

        static void OrderWords(string str)
        {

            string[] input = str.Split(' ');
            var result = input.OrderBy(x => x);
            foreach (var var in result)
            {
                Console.WriteLine(var);
            }

            Console.WriteLine();

            Array.Sort(input);
            string.Join(" ", input);
            foreach (var var in input)
            {
                Console.WriteLine(var);
            }

        }
    }
}
