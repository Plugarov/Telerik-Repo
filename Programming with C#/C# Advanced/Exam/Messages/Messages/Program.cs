using System;

namespace Messages
{
    class Program
    {

        static string[] code = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        static void Main()
        {
            string strOne = Console.ReadLine();
            string op = Console.ReadLine();
            string strTwo = Console.ReadLine();

            int numOne = Decrypt(strOne);
            int numTwo = Decrypt(strTwo);

            int result = 0;
            switch (op)
            {
                case "-": result = numOne - numTwo; break;
                case "+": result = numOne + numTwo; break;
            }

            Console.WriteLine(Encrypt(result));

        }

        private static int Decrypt(string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i += 3)
            {
                string chunk = str.Substring(i, 3);
                int indPos = Array.IndexOf(code, chunk);
                if (indPos >= 0)
                {
                    result = result * 10 + indPos;
                }
            }
            return result;
        }

        private static string Encrypt(int num)
        {
            string result = "";

            int digit = 0;
            while (num > 0)
            {
                digit = (num % 10);
                num /= 10;
                result = code[digit] + result;
            }
            return result;
        }
    }
}
