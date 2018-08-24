using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBracketsMethod
{
    class Program
    {
        static void Main()
        {
            string expression = "ab(()))";
            CorrectBrackets(expression);
        }

        static void CorrectBrackets(string expression)
        {
            bool correctBrackets = true;

            int counter = 0;
            int len = expression.Length;
       
            for (int i = 0; i < len; i++)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }
                else if (expression[i] == ')')
                {
                    counter--;
                }
            }

            if (counter % 2 == 0)
            {
                Console.WriteLine("Correct");
                correctBrackets = false;
            }

            if (correctBrackets)
            {
                Console.WriteLine("Incorrect");
            }


        }

    }
}
