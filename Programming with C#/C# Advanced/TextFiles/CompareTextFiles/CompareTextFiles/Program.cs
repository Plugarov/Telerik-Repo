using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFileToCompare = @"C:\Users\7\Desktop\result.txt";
            string secondFileToCompare = @"C:\Users\7\Desktop\resultWithLines.txt";
            Encoding encode = Encoding.UTF8;

            StreamReader read = new StreamReader(firstFileToCompare, encode);
            using (read)
            {
                StreamReader read2 = new StreamReader(secondFileToCompare, encode);
                using (read2)
                {
                    string line = read.ReadLine();
                    string line2 = read2.ReadLine();

                    int resultLine = 0;
                    List<string> result = new List<string>();
                    while (line != null)
                    {
                        if (string.Equals(line, line2))
                        {
                            result.Add(string.Format(@"{0} {1}", resultLine, line));
                        }
                        line = read.ReadLine();
                        line2 = read2.ReadLine();
                        resultLine++;
                    }
                    foreach (string res in result)
                    {
                        Console.WriteLine("{0}", res);
                    }
                }
            }
            //string[] linesOne = File.ReadAllLines("../../TextFileOne.txt");
            //string[] linesTwo = File.ReadAllLines("../../TextFileTwo.txt");

            //int maxLength = Math.Max(linesOne.Length, linesTwo.Length);
            //int minLength = Math.Min(linesOne.Length, linesTwo.Length);

            //for (int line = 0; line < maxLength; line++)
            //{
            //    if (line < minLength)
            //    {
            //        if (linesOne[line].Equals(linesTwo[line]))
            //        {
            //            Console.WriteLine("At line {0} : lines from both the file are same.", line);
            //        }
            //        else
            //        {
            //            Console.WriteLine("At line {0} : lines are not same.", line);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Line {0} : doesnt exits in {1} file.", line,
            //                                        linesOne.Length == minLength ? "first" : "second");
            //    }
            //}
        }
    }
}
