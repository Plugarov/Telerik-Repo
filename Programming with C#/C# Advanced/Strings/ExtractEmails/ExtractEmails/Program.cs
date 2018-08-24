using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string input = "This is sample text with some email addresses in it someemail@mail.ru or anotheremail@yahoo.com or example@gmail.com";
            ExtractEmail(input);
        }

        static void ExtractEmail(string str)
        {
            string strRegex = @"[A-Za-z0-9_\-\+]+@[A-Za-z0-9\-]+\.([A-Za-z]{2,3})(?:\.[a-z]{2})?";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);

            foreach (Match myMatch in myRegex.Matches(str))
            {
                Console.WriteLine(myMatch);
            }
        }
    }
}
