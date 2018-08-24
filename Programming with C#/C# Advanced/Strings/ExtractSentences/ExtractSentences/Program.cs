using System;
using System.Text;

namespace ExtractSentences
{
    class Program
    {
        static void Main()
        {
            string input = "We are living in a yellow submarine. We don't have anything else. " +
                "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            ExtractSentence(input);
        }

        static void ExtractSentence(string str)
        {
            StringBuilder resultString = new StringBuilder();
            
            string[] sentences = str.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;

            foreach (string sentence in sentences)
            {
                result = sentence.IndexOf(" in ");
                if (result > 0)
                {
                    resultString.Append(sentence.Trim() + ". ");
                }
            }
            Console.WriteLine(resultString);
        }
    }
}
