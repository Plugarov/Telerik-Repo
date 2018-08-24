using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Program
    {
        static void Main()
        {
            throw new InvalidRangeException<DateTime>(1, 200);
        }
    }

    public class InvalidRangeException<T> : ApplicationException
    {
        private int start;
        private int end;

        public InvalidRangeException(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }

        public int Start { get => start; set => start = value; }

        public int End { get => end; set => end = value; }

        public override string Message
        {
            get
            {
                return string.Format("{0} is out of the allowed range [{1} - {2}]",
                     typeof(T).Name, this.Start, this.End);

            }
        }
    }
}
