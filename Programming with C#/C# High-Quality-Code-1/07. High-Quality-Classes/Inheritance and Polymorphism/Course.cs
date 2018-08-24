namespace InheritanceAndPolymorphism
{   
    using System;
    using System.Collections.Generic;
    using System.Text;
  
    protected class Course : ICourse
    {
        private string courseName;
        private string teacherName;
        private List<string> students;

        protected Course(string courseName, string teacherName)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.courseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        protected string CourseName
        {
            get
            {
                return this.courseName;
            }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name can`t be empty.");
                }

                this.courseName = value;
            }
        }

        protected string TeachertName
        {
            get
            {
                return this.teachertName;
            }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Teacher name can`t be empty.");
                }

                this.teacherName = value;
            }
        }

        protected IList<string> Students
        {
            get
            {
                return this.students;
            }
            set 
            {
                if ( (myList!= null) && (!myList.Any()) )
                {
                    throw new ArgumentException("Students list can`t be empty.");
                }

                this.students = value;
            }
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                throw new ArgumentException("There are no students in the course.");
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        protected void Add(string student)
        {
            if (string.IsNullOrEmpty(student)){
                throw new ArgumentException("Can`t add null or empty value.");
            }

            if (student.Length < 2){
                throw new ArgumentException("Name can`t be shorter than 1 or less letters");
            }

            this.Students.Add(student);
        }

        protected override ToString()
        {
            string students = String.Join(", ", this.Students));
            string output = string.Format("Course: {0}\nCourse name: {1}\nTeacher name: {2}", this.CourseName, this.Teacher, students)
            return output;
        }
    }
}

