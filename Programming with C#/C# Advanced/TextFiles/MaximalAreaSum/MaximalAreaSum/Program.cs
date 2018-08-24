using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaximalAreaSum
{
    class Program
    {

        static void Main()
        {
            string path = @"C:\Users\7\Desktop\result.txt";
            Encoding encoding = Encoding.UTF8;
            string[] alllines = File.ReadAllLines(path, Encoding.UTF8);

            int rowLen = alllines.Length;
            int[][] jagged = new int[rowLen][];
            
            for (int i = 0; i < rowLen; i++)
            {
                int[] line = alllines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

                jagged[i] = line;
            }

            int maxSum = 0;
            for (int i = 0; i < jagged.Length - 1; i++)
            {
                int sum = 0;
                for (int y = 0; y < jagged[i].Length - 1; y++)
                {
                    sum = jagged[i][y] + jagged[i][y + 1] + jagged[i + 1][y] + jagged[i + 1][y + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        sum = 0;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int y = 0; y < jagged[i].Length; y++)
                {
                    Console.Write(string.Format("{0} ", jagged[i][y]));
                }
                Console.WriteLine();
            }
        }
    }
}
