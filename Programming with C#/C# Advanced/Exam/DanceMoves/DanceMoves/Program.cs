using System;

namespace DanceMoves
{
    class Program
    {
        static int currentPos = 0;
        static int[] floor = { 1, 2, 3, 5, 7, 10, 20 };
        static int sum = 0;

        static void Main()
        {
            string line = null;

            while ((line = Console.ReadLine()) != "stop")
            {
                var arr = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int moves = int.Parse(arr[0]);
                string dir = arr[1];
                int stepSize = int.Parse(arr[2]);

                // DO NOT PUT CONDITIONS IN LOOP LIKE MOVES STEP SIZE / IT GETS IT WRONG
                //for (int i = 0; i < moves + stepSize - 1; i += stepSize)
                //{
                //    if (dir == "right")
                //    {
                //        currentPos += stepSize;
                //        if (currentPos >= floor.Length)
                //        {
                //            currentPos = (currentPos - floor.Length) * (-1);
                //        }
                //        tempSum += floor[currentPos];
                //        Console.WriteLine(tempSum);
                //    }
                //    else
                //    {
                //        currentPos -= stepSize;
                //        if (currentPos < 0)
                //        {
                //            currentPos = (currentPos + floor.Length);
                //        }
                //        tempSum += floor[currentPos];
                //        Console.WriteLine(tempSum);
                //    }
                //}

                Move(moves, dir, stepSize);
            }
            Console.WriteLine(sum / 4);
        }

        static void Move(int moves, string dir, int stepSize)
        {
            for (int i = 0; i < moves; i++)
            {
                if (dir == "right")
                {
                    currentPos = (currentPos + stepSize) % floor.Length;
                }
                else
                {
                    currentPos = (currentPos - stepSize) % floor.Length < 0 ? floor.Length + (currentPos - stepSize) % floor.Length : (currentPos - stepSize) % floor.Length;
                }
                sum += floor[currentPos];
                Console.WriteLine(sum);
            }
        }
    }
}
