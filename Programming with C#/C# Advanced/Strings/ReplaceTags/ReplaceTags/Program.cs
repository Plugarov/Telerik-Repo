using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class Program
    {
        static void Main()
        {
            string input = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            ReplaceTags(input);
        }

        static void ReplaceTags(string text)
        {
            StringBuilder replacedString = new StringBuilder();
            string[] replaced = text.Split(new string[] { "<a href", "</a>" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in replaced)
            {
                int indexOfLink = word.IndexOf("=\"");

                if (indexOfLink >= 0)
                {
                    int endIndex = word.IndexOf("\">");
                    replacedString.Append("[");
                    replacedString.Append(word.Substring(endIndex + 2, word.Length - endIndex - 2));
                    replacedString.Append("](");
                    replacedString.Append(word.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
                    replacedString.Append(")");
                }
                else
                {
                    replacedString.Append(word);
                }
            }

            Console.WriteLine(replacedString);
        }
    }
}
