using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretNumeralSystem
{
    class Program
    {
        private static int snakeLen = 3;

        static void Main()
        {

            int[] dimensions = Console.ReadLine().Split(new string[] { "x" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] denMatrix = new char[dimensions[0], dimensions[1]];

            // Fills the matrix
            for (int row = 0; row < dimensions[0]; row++)
            {
                char[] current = Console.ReadLine().ToCharArray();

                for (int col = 0; col < dimensions[1]; col++)
                {
                    denMatrix[row, col] = current[col];
                }
            }

            char[] commands = Console.ReadLine().Replace(",", "").ToCharArray();


            SnakeMove(denMatrix, commands);
            PrintMatrix(denMatrix, dimensions);
        }

        private static void SnakeMove(char[,] denMatrix, char[] commands)
        {

            int[] snakePosition = new int[] { 0, 4 };
           
            int deltaRow = 0;
            int deltaCol = 0;

            int snakeNewRow = snakePosition[0];
            int snakeNewCol = snakePosition[1];

            int countMoves = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                countMoves++;

                if (commands[i] == 's')
                {
                    deltaRow++;
                }
                else if (commands[i] == 'w')
                {
                    deltaRow--;
                }
                else if (commands[i] == 'a')
                {
                    deltaCol--;
                }
                else if (commands[i] == 'd')
                {
                    deltaCol++;
                }
                else
                {

                }

                snakeNewRow += deltaRow;
                snakeNewCol += deltaCol;

                if (snakeNewCol < 0)
                {
                    snakeNewCol = denMatrix.GetLength(1) - 1;
                }

                if (snakeNewCol > denMatrix.GetLength(1))
                {
                    snakeNewCol = 0;
                }

                if (snakeNewRow >= denMatrix.GetLength(0))
                {
                    Console.WriteLine("Sneaky is going to be stuck in the den at {0} {1}", snakeNewRow, snakeNewCol);
                    break;
                }
                if (countMoves >= 5)
                {
                    snakeLen--;
                    countMoves = 0;
                }
                if (snakeLen < 0)
                {
                    Console.WriteLine("Sneaky is going to starve at {0} {1}", snakeNewRow, snakeNewCol);
                    break; 
                }
                if (denMatrix[snakeNewRow, snakeNewCol] == '@')
                {
                    snakeLen++;
                }
                if (denMatrix[snakeNewRow, snakeNewCol] == '%')
                {
                    Console.WriteLine("Sneaky is going to hit a rock at {0} {1}", snakeNewRow, snakeNewCol);
                    break;
                }
                if (snakeNewRow == 0 && snakeNewCol == 4)
                {
                    Console.WriteLine("Sneaky is going to get out with length {0}", snakeLen);
                    break;
                }


                denMatrix[snakeNewRow, snakeNewCol] = '-';
                snakePosition[0] = snakeNewRow;
                snakePosition[1] = snakeNewCol;

                deltaRow = 0;
                deltaCol = 0;
            }
            denMatrix[snakePosition[0], snakePosition[1]] = '7';
        }

        private static void PrintMatrix(char[,] denMatrix, int[] dimensions)
        {
            for (int row = 0; row < dimensions[0]; row++)
            {
                for (int col = 0; col < dimensions[1]; col++)
                {
                    Console.Write(string.Format("{0,2}", denMatrix[row, col]));
                }
                Console.WriteLine();
            }
        }
    }
}
