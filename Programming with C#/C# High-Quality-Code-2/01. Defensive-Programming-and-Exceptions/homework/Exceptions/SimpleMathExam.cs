namespace StudentSystem
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const string MAX_PROBLEMS_COUNT = 0;
        private const string MAX_PROBLEMS_COUNT = 2;

        private readonly Dictionary<int, KeyValuePair<int, string>> marksByProblemsSolved =
        new Dictionary<int, KeyValuePair<int, string>>()
        {
            { 0, new KeyValuePair<int, string>(2, "Bad result: nothing done.") },
            { 1, new KeyValuePair<int, string>(4, "Average result: something done.") },
            { 2, new KeyValuePair<int, string>(6, "Excellence result: everything done.") }
        };

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved 
        { 
            get
            {
                return this.problemsSolved;
            }
            private set
            {
                if (value < this.MIN_PROBLEMS_COUNT || value > this.MAX_PROBLEMS_COUNT )
                {
                    throw new ArgumentException(string.Format("Problems count should be in range {0} - {1}.", this.MIN_PROBLEMS_COUNT,  this.MAX_PROBLEMS_COUNT));
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            var mark = marksByProblemsSolved[this.problemsSolved];

            ExamResult result = new ExamResult(mark.key, this.MIN_GRADE, this.MAX_GRADE, mark.value);
            return result;
        }
    }
}