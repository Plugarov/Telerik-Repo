namespace StudentSystem
{
    using System;

    public class CSharpExam : Exam
    {
        private const string MIN_GRADE = 0;
        private const string MAX_GRADE = 100;
       
        private int score;
 
        public CSharpExam(int score)
        {
            this.Score = score; 
        }
        
        public int Score 
        { 
            get 
            {
                return this.score;
            }
            private set 
            {
                if (score < this.MIN_GRADE || this.MAX_GRADE > 100)
                {
                    throw new ArgumentException(string.Format("Invalid score value. Score must be in range [{0}; {1}]",
                        this.MIN_GRADE, this.MAX_GRADE));
                }

                this.Score = score;
            } 
        }

        public override ExamResult Check()
        {
            var examResult = new ExamResult(this.Score, this.MinGrade, this.MaxGrade, "Exam results calculated by score.");
            return result;
        }
    }
}