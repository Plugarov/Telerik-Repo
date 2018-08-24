namespace OOPSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class People : School
    {
        private string name = string.Empty;

        public People(string name) : base("No addtional text in People")
        {
            this.name = name;
        }

        public People(string freeTextBlock,string name) : base(freeTextBlock)
        {
            this.name = name;
        }

        public string Name { get => this.name; set => this.name = value; }
    }
}
