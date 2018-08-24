using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertations
{
    class Program
    {
        static void Main()
        {

            //Console.WriteLine(HexToDecimal("A2"));
            //Console.WriteLine(HexToBinary("A2"));
            //Console.WriteLine(HexToDecimal());
            //Console.WriteLine(BinaryToDecimal("1"));
            //Console.WriteLine(BinaryToHex("11111"));
            //Console.WriteLine(DecimalToBinary(3));
            //Console.WriteLine(DecimalToHexadecimal(23452354));
        }

        static int HexToDecimal(string number)
        {
            // 
            int result = 0;
            int multiplier = 0;

            for (int pos = 0; pos < number.Length; pos++)
            {
                switch (number[number.Length - pos - 1])
                {
                    case 'A': multiplier = 10; break;
                    case 'B': multiplier = 11; break;
                    case 'C': multiplier = 12; break;
                    case 'D': multiplier = 13; break;
                    case 'E': multiplier = 14; break;
                    case 'F': multiplier = 15; break;
                    default: multiplier = int.Parse(number[number.Length - pos - 1].ToString()); break;
                }
                result += multiplier * (short)Math.Pow(16, pos);
            }
            return result;
        }

        static string HexToBinary(string number)
        {
            string result = "";

            foreach (char digit in number)
            {

                switch (digit)
                {
                    case '1': result += "0001"; break;
                    case '2': result += "0010"; break;
                    case '3': result += "0011"; break;
                    case 'A': result += "1010"; break;
                    case 'B': result += "1011"; break;
                }

            }

            return result;
        }

        private static string BinaryToHex(string binNumber)
        {
            StringBuilder binaryNum = new StringBuilder(binNumber);

            bool isNegative = false;

            if (binaryNum[0] == '-')
            {
                isNegative = true;
                binaryNum.Remove(0, 1);
            }

            int length = binaryNum.Length;
            for (int i = 0; i < (4 - length % 4) % 4; i++)
            {
                binaryNum.Insert(0, '0');
            }

            StringBuilder hexNumber = new StringBuilder();

            StringBuilder word = new StringBuilder("0000");

            for (int fours = 0; fours < binaryNum.Length; fours += 4)
            {
                for (int pos = fours; pos < fours + 4; pos++)
                {
                    word[pos % 4] = binaryNum[pos];
                }

                switch (word.ToString())
                {
                    case "0000": hexNumber.Append('0'); break;
                    case "0001": hexNumber.Append('1'); break;
                    case "0010": hexNumber.Append('2'); break;
                    case "0011": hexNumber.Append('3'); break;
                    case "0100": hexNumber.Append('4'); break;
                    case "0101": hexNumber.Append('5'); break;
                    case "0110": hexNumber.Append('6'); break;
                    case "0111": hexNumber.Append('7'); break;
                    case "1000": hexNumber.Append('8'); break;
                    case "1001": hexNumber.Append('9'); break;
                    case "1010": hexNumber.Append('A'); break;
                    case "1011": hexNumber.Append('B'); break;
                    case "1100": hexNumber.Append('C'); break;
                    case "1101": hexNumber.Append('D'); break;
                    case "1110": hexNumber.Append('E'); break;
                    case "1111": hexNumber.Append('F'); break;
                }
            }

            if (isNegative)
            {
                hexNumber.Insert(0, '-');
            }

            return hexNumber.ToString();
        }

        static int BinaryToDecimal(string number)
        {
            int result = 0;

            int strLen = number.Length - 1;
            int digitDegree = 1;

            while (strLen >= 0)
            {
                if (char.GetNumericValue(number[strLen]) > 0)
                {
                    result += digitDegree;
                }
                digitDegree *= 2;
                strLen--;
            }
            return result;
        }


        static string DecimalToHexadecimal(int number)
        {
            string result = "";
            int digitValue = 0;
            string hexNumbers = "0123456789ABCDEF";
            do
            {
                digitValue = number % 16;
                number /= 16;
                result = hexNumbers[digitValue] + result;
            }
            while (number > 0);

            return result;
        }

        static string DecimalToBinary(int number)
        {
            StringBuilder result = new StringBuilder();
            int digitValue = 0;

            do
            {
                digitValue = number % 2;
                number /= 2;
                result.Append(digitValue);
            }
            while (number > 0);

            return result.ToString();
        }

    }


}
