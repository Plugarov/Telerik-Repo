namespace Computers.Components.VideoCards
{
    using System;

    using Computers.Interfaces;

    public class ColorfullVideoCard : IVideoCard
    {
        public void Draw(string a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(a);
            Console.ResetColor();
        }
    }
}
