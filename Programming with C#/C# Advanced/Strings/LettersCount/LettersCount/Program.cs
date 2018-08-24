using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersCount
{
    class Program
    {
        static void Main()
        {
            string input = "asdafgsdsadf sdfsdf ssssfgs565AAAg./,a";
            LetterCount(input);
        }

        static void LetterCount(string input)
        {

            int len = input.Length;
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (char i = 'A'; i < 'z'; i++)
            {
                if (!letters.ContainsKey(i) && input.Contains(i))
                {
                    letters.Add(i, 0);
                }
            }

            foreach (char ch in input)
            {
                if (letters.ContainsKey(ch))
                {
                    letters[ch]++;
                }
            }

            foreach (var word in letters)
            {
                Console.WriteLine("{0} - {1}", word.Key, word.Value);
            }

        }
    }
}
