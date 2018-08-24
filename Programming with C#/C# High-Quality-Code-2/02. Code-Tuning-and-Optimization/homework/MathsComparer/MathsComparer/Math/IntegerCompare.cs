namespace Comparer.Math
{
    using System;

    public class IntegerCompare : MathComparer
    {
        public void CalculateExecutionTime()
        {
            Console.WriteLine(this.GetType().Name);

            CalculateExecutionTime(() =>
            {
                int result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result += j;
                }
            }, "Average time in miliseconds for Sum.");

            CalculateExecutionTime(() =>
            {
                int result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result++;
                }
            }, "Average time in miliseconds for Increment.");

            CalculateExecutionTime(() =>
            {
                int result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result -= j;
                }
            }, "Average time in miliseconds for Substract.");

            CalculateExecutionTime(() =>
            {
                int result = 1;
                for (int j = 1; j < this.repeatTimes; j += 1)
                {
                    result /= j;
                }
            }, "Average time in miliseconds for Devide.");

            CalculateExecutionTime(() =>
            {
                int result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result *= j;
                }
            }, "Average time in miliseconds for Multiply.");
        }
    }
}
