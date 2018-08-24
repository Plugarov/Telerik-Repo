using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTags
{
    class Program
    {
        static void Main()
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else";
            ParseTags(str);
        }

        static void ParseTags(string text)
        {
            StringBuilder sb = new StringBuilder();

            int toUpper = -1;
            int len = text.Length;
            for (int i = 0; i < len; i++)
            {
                if (text[i] == '<')
                {
                    i++;
                    toUpper = toUpper * (-1);

                    while (text[i] != '>')
                    {
                        i++;
                    }
                }
                else
                {
                    if (toUpper == 1)
                    {
                        sb.Append(text[i].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(text[i]);
                    }
                }
            }

            Console.WriteLine(sb);

        }
    }
}
