using System;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());


            string aToBinary = Convert.ToString(a, 2).PadLeft(10, '0');
            string aTohexValue = a.ToString("X");

            string bToString = string.Format("{0:0.00}", b);
            string cToString = string.Format("{0:0.000}", c);

            Console.WriteLine("{0,-10} | {1,10} | {2,10} | {3,-10}", aTohexValue, aToBinary, bToString, cToString);
        }
    }
}
