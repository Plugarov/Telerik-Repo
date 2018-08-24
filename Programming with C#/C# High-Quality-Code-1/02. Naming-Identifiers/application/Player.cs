namespace MineGame
{
    using System;
    using System.Collections.Generic;

    internal class Player
    {
        public string name;
        public int points;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Player() { }

        public Player(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
    }
}