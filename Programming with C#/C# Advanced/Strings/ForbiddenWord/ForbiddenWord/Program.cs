using System;
using System.Collections.Generic;
using System.Text;

namespace ForbiddenWord
{
    class Program
    {
        static void Main()
        {
            string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and " +
                "is implemented as a dynamic language in CLR.";
            ForbiddenWords(input);
        }

        static void ForbiddenWords(string str)
        {
            StringBuilder replaced = new StringBuilder();

            List<string> forbiddenWords = new List<string>() {
                "PHP",
                "CLR",
                "Microsoft"
            };

            replaced.Append(str);

            foreach (string word in forbiddenWords)
            {
                replaced.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(replaced);
        }
    }
}
