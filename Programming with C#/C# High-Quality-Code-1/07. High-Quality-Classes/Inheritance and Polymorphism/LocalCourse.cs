namespace InheritanceAndPolymorphism
{   
    using System;
    using System.Collections.Generic;
    using System.Text;
  
    public class LocalCourse : Course, ICourse, ILocalCourse
    {
        private string labName;

        public LocalCourse(string courseName, string teacherName, string labName)
            : base(string courseName, string teacherName)
        {
            this.LabName = labName;
        }

       public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
            : base(string courseName, string teacherName, IList<string> students)
        {
            this.labName = labName;
        }

        public string LabName 
        {
            get
            {
                return this.labName;
            }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lab name can`t be empty.");
                }

                this.labName = value;
            }
        }

        public override ToString()
        {
            string output = string.Format("{0}\nLab name: {1}", base.ToString(), this.LabName)
            return output;
        }
    }
}