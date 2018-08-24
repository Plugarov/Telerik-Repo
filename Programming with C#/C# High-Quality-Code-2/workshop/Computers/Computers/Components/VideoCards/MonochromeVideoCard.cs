namespace Computers.Components.VideoCards
{
    using System;

    using Computers.Interfaces;

    public class MonochromeVideoCard : IVideoCard
    {
        public void Draw(string a)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(a);
            Console.ResetColor();
        }
    }
}
