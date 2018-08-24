using System;
using System.Text;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main()
        {
            string copyFromThisFile = @"C:\Users\7\Desktop\result.txt";
            string pasteToThisFile = @"C:\Users\7\Desktop\resultWithLines.txt";
            Encoding encoder = Encoding.UTF8;

            StreamReader read = new StreamReader(copyFromThisFile, encoder);
            using (read)
            {
                int lineNum = 1;
                string line = read.ReadLine();
                StreamWriter write = new StreamWriter(pasteToThisFile, false, encoder);
                using (write)
                {
                    while (line != null)
                    {
                        write.WriteLine(string.Format("{0} {1}", lineNum, line));
                        lineNum++;
                        line = read.ReadLine();
                    }
                }

            }
        }
    }
}
