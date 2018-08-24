namespace AcademyRPG.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public struct Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public static Point Parse(string command)
        {
            List<int> dimension = command
                 .Split(new Char[] { ')', '(', ',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToList();

            return new Point(dimension[0], dimension[1]);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

