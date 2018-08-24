namespace OOPSchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SchoolClass : School
    {
        private string classIdentifyer = string.Empty;
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string classIdentifyer, List<Student> students, List<Teacher> teachers) : base("School Class : free text block is empty")
        {
            this.classIdentifyer = classIdentifyer;
            this.students = students;
            this.teachers = teachers;
        }

        public SchoolClass(string freeTextBlock,string classIdentifyer, List<Student> students, List<Teacher> teachers) : base(freeTextBlock)
        {
            this.classIdentifyer = classIdentifyer;
            this.students = students;
            this.teachers = teachers;
        }

        public string ClassIdentifyer { get => this.classIdentifyer; set => this.classIdentifyer = value; }

        public List<Student> Students { get => this.students; set => this.students = value; }

        public List<Teacher> Teachers { get => this.teachers; set => this.teachers = value; }
    }
}
