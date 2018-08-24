using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class Program
    {
        static void Main()
        {
            int input = 45;
            ConvertNum(input);
        }

        static void ConvertNum(int input)
        {
            string binary = Convert.ToString(input,2).PadLeft(16,'0'); //Binary
            string hex = input.ToString("X").PadLeft(16, ' '); //Hexadecimal
            string sn = string.Format("{0:E}", input).PadLeft( 16, ' '); //Scientific Notation
            Console.WriteLine(string.Format("{0,-20}\n{1,10}\n{2,15}", binary, hex, sn));

            // or

            Console.WriteLine();
            Console.WriteLine("{0,15:D}", input); // Decimal 
            Console.WriteLine("{0,15:X}", input); // Hexadecimal 
            Console.WriteLine("{0,15:P}", input); // Percentage 
            Console.WriteLine("{0,15:E}", input); // Scientific notation 


        }
    }
}
