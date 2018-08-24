using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromHTML
{
    class Program
    {
        static void Main()
        {

            StringBuilder str = new StringBuilder();

            string input = string.Empty;
            while(true)
            {
                input = Console.ReadLine().Trim();
                if (input != string.Empty)
                {
                    str.Append(input);
                }
                else
                {
                    Console.WriteLine("End of input");
                    break;
                }
            }
            ExtractFromHTML(str);
        }

        static void ExtractFromHTML(StringBuilder inputString)
        {

            string str = inputString.ToString();
            StringBuilder result = new StringBuilder();


            int startTag = str.IndexOf("<title>");
            int endTag = str.IndexOf("</title");

            result.Append("Title: ");
            result.Append(str.Substring(startTag + 7, endTag - startTag - 7));
            result.Append("\n");

            startTag = str.IndexOf("<p>");
            endTag = str.IndexOf("</p>");

            result.Append("Text : ");
            result.Append(str.Substring(startTag + 3, endTag - startTag - 7)
                .Split(new string[] { "</a>" }, StringSplitOptions.RemoveEmptyEntries)[0]
                .Split('>')[1]);

            result.Append(str.Substring(startTag + 3, endTag - startTag - 3)
                .Split(new string[] { "</a>" }, StringSplitOptions.RemoveEmptyEntries)[1]);
        
            Console.WriteLine(result);
        }

    }
}
