namespace StartUp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Generics
    {
        private string[] brands;
        private int count = 0;

        public Generics()
        {
            this.brands = new string[8];
        }

        public void Add(string item)
        {
            this.brands[this.count] = item;
            this.count++;
        }

        public void Remove(string item)
        {
            this.brands[this.count] = default(string);
        }

        public string[] RetrunList()
        {
            return this.brands;
        }
    }
}
