using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main()
        {

            int size = 4;
            string type = "c";
            FillMatrix(size, type);
        }

        static void FillMatrix(int size, string type)
        {

            int[,] matrix = new int[size, size];

            switch (type)
            {
                case "a": VerticalFillMatrixA(size, matrix); break;
                case "b": SnakeFillMatrixB(size, matrix); break;
                case "c": DiagonalFillMatrixC(size, matrix); break;
                    //case "d": SpiralFillMatrixD(size, matrix); break;
            }
            PrintMatrix(matrix);
        }

        static int[,] VerticalFillMatrixA(int size, int[,] matrix)
        {
            for (int i = 0, count = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++, count++)
                {
                    matrix[j, i] = count;
                }
            }
            return matrix;
        }

        static int[,] SnakeFillMatrixB(int size, int[,] matrix)
        {
            int count = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = count;
                    }
                    else
                    {
                        int reverseRow = size - row - 1;
                        matrix[reverseRow, col] = count;
                    }
                    count++;
                }
            }
            return matrix;
        }

        static int[,] DiagonalFillMatrixC(int size, int[,] matrix)
        {
            int count = 1;
            int switchRow = 0;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = size - 1; row >= 0; row--)
                {
                    if (switchRow == 1 && col != 3)
                    {
                        row = 0;
                        switchRow = 0;
                    }
                    matrix[row, col] = count;
                    count++;
                    switchRow++;
                }
            }
            return matrix;
        }






        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,4}", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
