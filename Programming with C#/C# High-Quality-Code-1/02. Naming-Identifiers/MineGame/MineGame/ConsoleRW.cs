namespace MineGame
{
    using System;
    using System.Collections.Generic;

    public static class ConsoleRW
    {

        public static void Writer(string text)
        {
            Console.log(text);
        }

        public string Reader()
        {
            string input = Console.ReadLine().Trim();

            return input;
        }
    }
}