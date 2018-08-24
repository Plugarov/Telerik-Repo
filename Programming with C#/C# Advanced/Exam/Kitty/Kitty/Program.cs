using System;
using System.Linq;

namespace Kitty
{
    class Program
    {
        static string[] pathArr = null;
        static int[] stepsArr = null;

        static int currentPos = 0;
        static int countFood = 0;
        static int countSouls = 0;
        static int countJumps = 0;
        static int countDeadlocks = 0;

        static void Main()
        {

            pathArr = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();
            stepsArr = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (CheckPosition())
                return;

            foreach (int step in stepsArr)
            {
                Move(step);
                countJumps++;
                if (CheckPosition())
                    return;
            }
            Console.WriteLine("Coder souls collected: {0}\r\nFood collected: {1}\r\nDeadlocks: {2}", countSouls, countFood, countDeadlocks);
        }

        private static bool CheckPosition()
        {

            if (pathArr[currentPos] == "@")
            {
                countSouls++;
                pathArr[currentPos] = "0";
            }
            else if (pathArr[currentPos] == "*")
            {
                countFood++;
                pathArr[currentPos] = "0";
            }
            else if (pathArr[currentPos] == "x")
            {
                countDeadlocks++;

                if (currentPos % 2 == 0)
                {
                    if (countSouls < 1)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", countJumps);
                        return true;
                    }

                    pathArr[currentPos] = "@";
                    countSouls -= 1;
                }
                else
                {
                    if (countFood < 1)
                    {
                        Console.WriteLine("You are deadlocked, you greedy kitty!");
                        Console.WriteLine("Jumps before deadlock: {0}", countJumps);
                        return true;
                    }

                    pathArr[currentPos] = "*";
                    countFood -= 1;
                }
            }
            return false;
        }


        private static void Move(int step)
        {
            currentPos = (currentPos + step) % pathArr.Length < 0 ? (currentPos + step) % pathArr.Length + pathArr.Length : (currentPos + step) % pathArr.Length;
        }
    }
}