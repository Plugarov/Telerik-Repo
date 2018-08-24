using System;
using System.Text;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main()
        {



            var file = @"C:\Users\7\Desktop\filse.txt";
            Encoding encoding = Encoding.UTF8;
            StreamReader reader = new StreamReader(file, encoding);

            using (reader)
            {
                try
                {
                    string fileContent = string.Empty;
                    int counter = 0;
                    while (fileContent != null)
                    {
                        fileContent = reader.ReadLine();
                        if (counter % 2 == 0)
                            Console.WriteLine(fileContent);

                        counter++;
                    }

                }
                catch (FileNotFoundException )
                {
                    
                }
                catch (ArgumentException)
                {

                }
                catch (DirectoryNotFoundException)
                {

                }
                catch (NotSupportedException)
                {

                }
            }
        }
    }
}