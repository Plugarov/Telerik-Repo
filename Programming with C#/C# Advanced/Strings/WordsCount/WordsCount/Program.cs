using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Write a program asd that reads a string from the console from and lists from all different words in the string along with information how many times each word is found";
            CountWords(input);
        }

        static void CountWords(string input)
        {
            string[] str = input.Split(new char[] { ' ', ',', '.', '-', '!', ':' }, 
             StringSplitOptions.RemoveEmptyEntries); 


            var result = new Dictionary<string, int>();

            foreach (string word in str)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result.Add(word, 1);
                }
            }

            foreach (var word in result)
            {
                Console.WriteLine("{0} - {1}", word.Key, word.Value);
            }
        }
    }
}
