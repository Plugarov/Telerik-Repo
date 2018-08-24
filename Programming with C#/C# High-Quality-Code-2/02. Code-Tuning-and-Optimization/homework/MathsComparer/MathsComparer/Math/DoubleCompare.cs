namespace Comparer.Math
{
    using System;

    public class DoubleCompare : MathComparer
    {
        public void CalculateExecutionTime()
        {
            Console.WriteLine(this.GetType().Name);

            CalculateExecutionTime(() =>
            {
                double result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result += j;
                }
            }, "Average time in miliseconds for Sum.");

            CalculateExecutionTime(() =>
            {
                double result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result++;
                }
            }, "Average time in miliseconds for Increment.");

            CalculateExecutionTime(() =>
            {
                double result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result -= j;
                }
            }, "Average time in miliseconds for Substract.");

            CalculateExecutionTime(() =>
            {
                double result = 1;
                for (int j = 1; j < this.repeatTimes; j += 1)
                {
                    result /= j;
                }
            }, "Average time in miliseconds for Devide.");

            CalculateExecutionTime(() =>
            {
                double result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result *= j;
                }
            }, "Average time in miliseconds for Multiply.");

            CalculateExecutionTime(() =>
            {
                double numberToTest = 100;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    Math.Sqrt(numberToTest);
                }
            }, "Average time in miliseconds for SquareRoot.");

            CalculateExecutionTime(() =>
            {
                double numberToTest = 100;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    Math.Log(numberToTest);
                }
            }, "Average time in miliseconds for logarithm of a specified number.");

            CalculateExecutionTime(() =>
            {
                double numberToTest = 100;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    Math.Sin(numberToTest);
                }
            }, "Average time in miliseconds for sinus.");

        }
    }
}