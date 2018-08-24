namespace StudentSystem
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string exams;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid first name!");
                    Environment.Exit(0);
                }

                this.firstName = value
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid last name!");
                    Environment.Exit(0);
                }
                
                this.lastName = value
            }
        }

        public IList<Exam> Exams 
        {
            get
            {
                return this.exams;
            }
            set
            {
                if ( (value!= null) && (!value.Any()) )
                {
                    throw new ArgumentException("Invalid exams list!");
                    Environment.Exit(0);
                }
                
                this.exams = value
            }
        }

        private IList<ExamResult> CheckExams()
        {
            IList<ExamResult> results = new List<ExamResult>();
            
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i]);
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();

            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = examResults[i].CalcAverageExamResultInPercents();
            }

            return examScore.Average();
        }
    }
}