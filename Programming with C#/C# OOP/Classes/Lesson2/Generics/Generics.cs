namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Box<T>
    {
        private List<T> intList;

        public Box()
        {
            this.intList = new List<T>();
        }

        public void print()
        {
            if (this.intList.Count != 0)
            {
                foreach (T element in this.intList)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            else
            {
                throw new StackOverflowException();
            }
        }

        public void push(T v)
        {
            this.intList.Insert(0, v);
        }

        public void pop()
        {
            this.intList.RemoveAt(0);
        }
    }
}
