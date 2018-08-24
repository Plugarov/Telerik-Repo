namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade { get => this.grade; set => this.grade = value; }
    }
}
