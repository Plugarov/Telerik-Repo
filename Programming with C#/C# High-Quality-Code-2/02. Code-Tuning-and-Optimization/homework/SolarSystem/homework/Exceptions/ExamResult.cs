namespace StudentSystem
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Grade = grade;
            this.Comments = comments;
        }

        public int Grade 
        {  
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < this.MinGrade || value > this.MaxGrade)
                {
                    throw new ArgumentException(
                        string.Format("Invalid grade. Should be between{0} and {1}", 
                        this.MinGrade,this.MaxGrade));
                }

                this.grade = value;
            }
        }

        public int MinGrade 
        {  
            get
            {
                return this.minGrade;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid grade. Shouldn`t be less than 0");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade 
        {  
            get
            {
                return this.maxGrade;
            }
            private set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Invalid grade. Shouldn`t be more than than 100.");
                }

                this.maxGrade = value;
            }
        }

        public string Comments 
        {
            get
            {
                return this.comments;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Comment can`t be empty.");
                }

                this.comments = value;
            }
        }

        public string CalcAverageResultInPercent()
        {
            double examResultPercents = (this.Grade - this.MinGrade) / (this.MaxGrade - this.MinGrade);
            return examResultPercents;
        } 
    }
}