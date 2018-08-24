namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string courseName, string teacher, string town)
            : base(string courseName, string teacher)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(string courseName, string teacherName, IList<string> students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Town name can`t be empty.");
                }

                this.lab = value;
            }
        }

        public override ToString()
        {
            string output = string.Format("{0}\nTown: {1}", base.ToString(), this.Town)
            return output;
        }
    }
}