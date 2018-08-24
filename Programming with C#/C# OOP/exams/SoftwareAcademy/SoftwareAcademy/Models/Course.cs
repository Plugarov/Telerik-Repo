namespace SoftwareAcademy.Models
{
    using SoftwareAcademy.Interfaces;
    using System.Collections.Generic;

    public abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private ICollection<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
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

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            Validator.checkIfNullOrEmpty(topic);
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            string format = string.Format("{0}: Name = {1};", this.GetType().Name, this.name);

            if (this.teacher != null)
            {
                format += string.Format(" Teacher = {0};", Teacher.Name);
            }
            if (this.topics.Count > 0)
            {
                format += string.Format(" Topics =[{0}];", string.Join(", ", this.topics));
            }

            return format;
        }
    }
}
