using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentences
{
    class Program
    {
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            ReverseSentence(input);
        }

        static void ReverseSentence(string str)
        {
            StringBuilder reversed = new StringBuilder();
            string[] split = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                
            for (int i = split.Length - 1; i > 0 ; i--)
            {
                reversed.Append(split[i] + ' ');
            }

            Console.WriteLine(reversed);
        }

        //TODO
    }
}
