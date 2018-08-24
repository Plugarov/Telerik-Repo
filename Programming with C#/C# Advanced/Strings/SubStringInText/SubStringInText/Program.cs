using System;

namespace SubStringInText
{
    class Program
    {
        static void Main()
        {
            string str = "We are living in an yellow submarine. We don't have in anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            FindOccurrences(str);
        }

        static void FindOccurrences(string str)
        {
            string searchString = "in";
            int len = searchString.Length;
            int counter = 0;
            int start = 0;

            while (true)
            {
                start = str.IndexOf(searchString, start + len);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
