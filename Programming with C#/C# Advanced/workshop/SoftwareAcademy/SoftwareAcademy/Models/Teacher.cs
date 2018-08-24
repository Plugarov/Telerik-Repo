namespace SoftwareAcademy.Models
{
    using System.Collections.Generic;
    using SoftwareAcademy.Interfaces;
    using System.Linq;

    public class Teacher : ITeacher
    {
        private string name;
        private List<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.checkIfNullOrEmpty(value);
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            Validator.checkIfNullObj(course);
            this.courses.Add(course);
        }

        public override string ToString()
        {
            string format = "Teacher: Name={0}";

            if (this.courses.Count > 0)
            {
                format += "; Courses=[{1}]";
            }

            IEnumerable<string> courseNames = this.courses.Select(x => x.Name);
            string result = string.Format(format, this.name, string.Join(", ", courseNames));

            return result;
        }
    }
}
