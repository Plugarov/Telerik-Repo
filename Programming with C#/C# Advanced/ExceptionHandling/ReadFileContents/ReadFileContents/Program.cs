using System;
using System.Text;
using System.IO;

namespace ReadFileContents
{
    class Program
    {
        static void Main()
        {
            string filename = @"C:\Users\7\Desktop\file.txt";
            var encoding = Encoding.UTF8;

            try
            {
                StreamReader reader = new StreamReader(filename, encoding, false);
                using (reader)
                {
                    string fileContent = string.Format("{0}", reader.ReadToEnd());
                    
                    if (!File.Exists(filename))
                    {
                        throw new Exception();
                    }

                    if (string.IsNullOrEmpty(fileContent))
                    {
                        throw new Exception("File is empty");
                    }

                    Console.WriteLine(fileContent);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
