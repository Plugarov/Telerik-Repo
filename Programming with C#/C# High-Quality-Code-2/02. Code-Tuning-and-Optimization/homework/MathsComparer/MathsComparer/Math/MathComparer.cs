namespace Comparer.Math
{
    using System;
    using System.Diagnostics;

    public abstract class MathComparer
    {
        protected const sbyte repeatTimesToCalculateAverage = 10;
        protected long repeatTimes = 1000000;

        protected static void CalculateExecutionTime(Action action, string message)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < repeatTimesToCalculateAverage; i += 1)
            {
                action();
            }
            stopwatch.Stop();

            var averageExecutionTime = stopwatch.ElapsedMilliseconds / repeatTimesToCalculateAverage;
            Console.WriteLine(string.Format("{0} {1}", message, averageExecutionTime));
        }
    }
}