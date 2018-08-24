using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPlanet
{
    class Program
    {
        // Creatures start position
        static int curPosPRow = 1;
        static int curPosPCol = 1;

        static int curPosRRow = 0;
        static int curPosRCol = 0;

        // Field dimensions
        static int rows = 0;
        static int baseCols = 0;

        static int[][] field = new int[rows][];

        // 
        static int sum = 0;

        static void Main()
        {
            rows = 8;
            baseCols = 2;

            field = new int[rows][];

            for (int i = 0; i < rows; ++i)
            {
                field[i] = new int[(i < rows / 2 ? i + 1 : rows - i) * baseCols];
                for (int j = 0; j < field[i].Length; ++j)
                {
                    field[i][j] = (i + 1) * (j + 1);
                }
            }

            field[curPosPRow][curPosPCol] = 0;
            field[curPosRRow][curPosRCol] = 0;

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "END")
            {
                string[] commands = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string creature = commands[0];
                string dir = commands[1];
                int steps = int.Parse(commands[2]);

                Move(creature, dir, steps);

            }
            PrintMap(field);
            Console.WriteLine(sum);
        }

        private static void Move(string creature, string dir, int steps)
        {

            for (int i = 0; i < steps; i++)
            {
                int deltaRow = 0;
                int deltaCol = 0;

                if (dir == "T")
                {
                    deltaRow -= (creature == "P" ? 1 : 3);
                }
                else if (dir == "B")
                {
                    deltaRow += (creature == "P" ? 1 : 3);
                }
                else if (dir == "R")
                {
                    deltaCol += (creature == "P" ? 1 : 3);
                }
                else if (dir == "L")
                {
                    deltaCol -= (creature == "P" ? 1 : 3);
                }
                else
                {

                }

                int newPosRow = (creature == "P" ? curPosPRow + deltaRow : curPosRRow + deltaRow);
                int newPosCol = (creature == "P" ? curPosPCol + deltaCol : curPosRCol + deltaCol);

                Console.WriteLine();


                if (newPosRow > field.GetLength(0) - 1)
                {
                    newPosRow = newPosRow % field.GetLength(0);
                }

                if (newPosRow < 0)
                {
                    newPosRow += field.GetLength(0);
                }

                if (newPosCol > (field[newPosRow].Length) - 1)
                {
                    newPosCol = newPosCol % (field[newPosRow].Length);
                }

                if (newPosCol < 0)
                {
                    newPosCol += field[newPosRow].Length;
                }

                sum += field[newPosRow][newPosCol];
                field[newPosRow][newPosCol] = 0;

                switch (creature)
                {
                    case "R":
                        curPosRRow = newPosRow;
                        curPosRCol = newPosCol;
                        break;
                    case "P":
                        curPosPRow = newPosRow;
                        curPosPCol = newPosCol;
                        break;
                }

            }
        }

        private static void PrintMap(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int y = 0; y < jaggedArray[i].Length; y++)
                {
                    Console.Write("{0,3}", jaggedArray[i][y]);
                }
                Console.WriteLine();
            }
        }
    }
}
