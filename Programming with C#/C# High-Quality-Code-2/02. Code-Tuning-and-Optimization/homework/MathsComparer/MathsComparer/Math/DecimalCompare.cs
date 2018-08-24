namespace Comparer.Math
{
    using System;

    public class DecimalCompare : MathComparer
    {
        public void CalculateExecutionTime()
        {
            Console.WriteLine(this.GetType().Name);

            CalculateExecutionTime(() =>
            {
                decimal result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result += j;
                }
            }, "Average time in miliseconds for Sum.");

            CalculateExecutionTime(() =>
            {
                decimal result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result++;
                }
            }, "Average time in miliseconds for Increment.");

            CalculateExecutionTime(() =>
            {
                decimal result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result -= j;
                }
            }, "Average time in miliseconds for Substract.");

            CalculateExecutionTime(() =>
            {
                decimal result = 1;
                for (int j = 1; j < this.repeatTimes; j += 1)
                {
                    result /= j;
                }
            }, "Average time in miliseconds for Devide.");

            CalculateExecutionTime(() =>
            {
                decimal result = 0;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    result *= j;
                }
            }, "Average time in miliseconds for Multiply.");

            CalculateExecutionTime(() =>
            {
                decimal numberToTest = 100;
                decimal root;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    root = (decimal)Math.Sqrt((double)numberToTest);
                }
            }, "Average time in miliseconds for SquareRoot.");

            CalculateExecutionTime(() =>
            {
                decimal numberToTest = 100;
                decimal root;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    root = (decimal)Math.Log((double)numberToTest);
                }
            }, "Average time in miliseconds for logarithm of a specified number.");

            CalculateExecutionTime(() =>
            {
                decimal numberToTest = 100;
                decimal root;
                for (int j = 0; j < this.repeatTimes; j += 1)
                {
                    root = (decimal)Math.Sin((double)numberToTest);
                }
            }, "Average time in miliseconds for sinus.");
        }
    }
}