namespace Comparer
{
    using Comparer.Sorting;
    using Comparer.Math;

    class ComparerMain
    {
        static void Main()
        {
            //IntegerCompare integerCompare = new IntegerCompare();
            //DoubleCompare doubleCompare = new DoubleCompare();
            //FloatCompare floatCompare = new FloatCompare();
            //LongCompare longCompare = new LongCompare();
            //DecimalCompare decimalCompare = new DecimalCompare();

            //integerCompare.CalculateExecutionTime();
            //doubleCompare.CalculateExecutionTime();
            //floatCompare.CalculateExecutionTime();
            //longCompare.CalculateExecutionTime();
            //decimalCompare.CalculateExecutionTime();

            DoubleSortCompare doubleSortCompare = new DoubleSortCompare(10, 10000);
            IntegerSortCompare integerSortCompare = new IntegerSortCompare(10, 10000);
            StringSortCompare stringSortCompare = new StringSortCompare(10, 10000);

            doubleSortCompare.DisplayExecutionTime(new double[] { 10.4, 3.3, 1.2, 2.5, 5.6 });
            integerSortCompare.DisplayExecutionTime(new int[] { 10, 3, 1, 2, 5 });
            stringSortCompare.DisplayExecutionTime(new string[] { "10", "3", "1", "2", "5" });



        }
    }
}
