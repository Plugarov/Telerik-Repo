using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO
namespace RemoveWords
{
    class Program
    {
        static void Main()
        {
            string file1 = @"C:\Users\7\Desktop\file1.txt";
            string file2 = @"C:\Users\7\Desktop\file2.txt";
            RemoveMatchingWords(MatchWord(file1), MatchWord(file2));
        }

        static void RemoveMatchingWords(List<string> file1, List<string> file2)
        {
            // compare words
        }

        static List<string> MatchWord(string path)
        {
            // return list of words
            return;
        }
    }
}
