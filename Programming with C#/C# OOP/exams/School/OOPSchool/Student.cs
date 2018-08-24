namespace OOPSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : People
    {
        private int classNumber;

        public Student(int classNumber, string name) : base("Student : : free text block is empty", name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string freeTextBlock,int classNumber, string name) : base(freeTextBlock,name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get => this.classNumber; set => this.classNumber = value; }
    }
}
