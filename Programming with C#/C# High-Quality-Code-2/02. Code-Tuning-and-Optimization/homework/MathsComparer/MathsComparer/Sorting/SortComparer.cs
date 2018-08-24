namespace Comparer.Sorting
{
    using System;
    using System.Diagnostics;

    public abstract class SortComparer
    {
        private sbyte repeatTimesToCalculateAverage;
        private long repeatTimes;

        public SortComparer(sbyte repeatTimesToCalculateAverage, long repeatTimes)
        {
            this.RepeatTimesToCalculateAverage = repeatTimesToCalculateAverage;
            this.RepeatTimes = repeatTimes;
        }

        protected sbyte RepeatTimesToCalculateAverage
        {
            get
            {
                return this.repeatTimesToCalculateAverage;
            }
            set
            {
                this.repeatTimesToCalculateAverage = value;
            }
        }

        protected long RepeatTimes
        {
            get
            {
                return this.repeatTimes;
            }
            set
            {
                this.repeatTimes = value;
            }
        }

        protected void CalculateExecutionTime(Action action, string message)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < repeatTimesToCalculateAverage; i += 1)
            {
                for (int j = 0; j < repeatTimes; j += 1)
                {
                    action();
                }
            }

            stopwatch.Stop();

            var averageExecutionTime = stopwatch.ElapsedMilliseconds / repeatTimesToCalculateAverage;
            Console.WriteLine(string.Format("{0} {1}", message, averageExecutionTime));
        }
    }
}