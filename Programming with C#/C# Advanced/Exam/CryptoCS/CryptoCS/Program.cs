using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCS
{
    class Program
    {
        static void Main()
        {
            string firstN = Console.ReadLine();
            string op = Console.ReadLine();
            string secondN = Console.ReadLine();

            int firstNumber = Decrypt(firstN, 26);
            int secondNumber = Decrypt(secondN, 7);

            Console.WriteLine(secondNumber);
            int result = (op == "-" ? firstNumber - secondNumber : firstNumber + secondNumber);
            Encrypt(result, 9);

        }

        private static int Decrypt(string num, int ns)
        {
            int result = 0;

            foreach (char digit in num)
            {
                result = result * ns + digit - (ns == 26 ? 'a' : '0');
            }

            return result;
        }

        private static void Encrypt(int num, int sys)
        {
            string result = string.Empty;
            do
            {
                result = (num % sys) + result;
                num /= sys;
            }
            while (num > 0);
            Console.WriteLine(result);
        }
    }

}
