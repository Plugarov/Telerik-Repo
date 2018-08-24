using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshoCode
{
    class Program
    {
        static void Main()
        {
            string key = Console.ReadLine();
            int numLines = int.Parse(Console.ReadLine());

            string line = string.Empty;
            List<string> sb = new List<string>();
            
            for (int i = 0; i < numLines; i++)
            {
                line = Console.ReadLine();
                sb.Add(line);
            }

            string str = string.Join(" ", sb);

            int keyPos = str.IndexOf(key);
            int beggining = 0;


            for (int i = keyPos; i > 0; i--)
            {
                if (str[i] > 65 && str[i] < 91)
                {
                    beggining = i;
                    break;
                }
            }

            string res = "";

            for (int i = keyPos + key.Length; i < str.Length; i++)
            {
                int sentenceEnd = i;
                if (str[i] == '.')
                {
                    res = str.Substring(keyPos + key.Length, sentenceEnd - (keyPos + key.Length));
                    break;
                }
                else if (str[i] == '!')
                {
                    res = str.Substring(beggining, keyPos - beggining);
                    break;
                }
            }

            string gluedSubstring = res.ToString().Replace(" ", string.Empty);
            int result = 0;

            foreach (var character in gluedSubstring)
            {
                result += character * key.Length;
            }

            Console.WriteLine(result);

        }
    }
}
