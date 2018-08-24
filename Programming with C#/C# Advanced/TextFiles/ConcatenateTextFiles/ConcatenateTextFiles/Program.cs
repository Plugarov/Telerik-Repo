using System;
using System.Text;
using System.IO;

namespace ConcatenateTextFiles
{
    class Program
    {
        static void Main()
        {
            var output = File.Create(@"C:\Users\7\Desktop\result.txt");

            using (output)
            {
                string[] files = { @"C:\Users\7\Desktop\file.txt", @"C:\Users\7\Desktop\file2.txt" };

                foreach (var file in files)
                {
                    using (var input = File.OpenRead(file))
                    {
                        input.CopyTo(output);
                    }
                }
            }

            string path = @"C:\Users\7\Desktop\result.txt";
            Encoding encode = Encoding.GetEncoding("windows-1251");

            StreamReader reader = new StreamReader(path, encode);

            using (reader)
            {
                int lineNumber = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    Console.WriteLine(string.Format("{0} {1}", lineNumber, line));

                    line = reader.ReadLine();
                }
            }


        }
    }
}
