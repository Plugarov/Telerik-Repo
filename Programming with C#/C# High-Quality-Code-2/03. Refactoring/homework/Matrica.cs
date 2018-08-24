namespace Task3
{
    using System;

    class WalkInmatrix
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //intdimensionSize= 0;
            //while ( !int.TryParse( input, outdimensionSize) ||dimensionSize< 0 ||dimensionSize> 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //}
            // mod  
            int dimensionSize = 6;
            int[,] matrix = new int[dimensionSize, dimensionSize];
            int step = dimensionSize,
               counter = 1,
               row = 0,
               col = 0,
               deltaX = 1,
               deltaY = 1;

            while (true)
            {
                matrix[row, col] = counter;

                if (AreAllNextCellsOccupied(matrix, row, col))
                {
                    FindEmptyCell(matrix, out row, out col);
                }

                if (counter == 34)
                {
                    break;
                }

                while ((row + deltaX >= dimensionSize ||
                   row + deltaX < 0 ||
                   col + deltaY >= dimensionSize ||
                   col + deltaY < 0 ||
                    matrix[row + deltaX, col + deltaY] != 0))
                {
                    Console.WriteLine(row);
                    Console.WriteLine(col);
                    change(ref deltaX, ref deltaY);
                }

                row += deltaX;
                col += deltaY;
                counter++;
            }

            PrintMatrix(dimensionSize, matrix);
        }

        private static void PrintMatrix(int dimensionSize, int[,] matrix)
        {
            for (int row = 0; row < dimensionSize; row++)
            {
                for (int col = 0; col < dimensionSize; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        static void change(ref int deltaX, ref int deltaY)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == deltaX &&
                    dirY[count] == deltaY)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                deltaX = dirX[0];
                deltaY = dirY[0];
                return;
            }

            deltaX = dirX[cd + 1];
            deltaY = dirY[cd + 1];
        }

        static bool AreAllNextCellsOccupied(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int row = 0; row < 8; row++)
            {
                if (x + dirX[row] >= arr.GetLength(0) || x + dirX[row] < 0)
                {
                    dirX[row] = 0;
                }

                if (y + dirY[row] >= arr.GetLength(0) || y + dirY[row] < 0)
                {
                    dirY[row] = 0;
                }
            }

            for (int row = 0; row < 8; row++)
            {
                if (arr[x + dirX[row], y + dirY[row]] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void FindEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(0); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }
    }
}
