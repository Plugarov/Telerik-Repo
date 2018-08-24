namespace OOPSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base("Teacher : : free text block is empty", name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string freeTextBlock, string name) : base("you can add coments in free text block", name)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string freeTextBlock, string name, List<Discipline> disciplines) : base(freeTextBlock, name)
        {
            this.disciplines = disciplines;
        }

        public List<Discipline> Disciplines { get => this.disciplines; set => this.disciplines = value; }
    }
}
