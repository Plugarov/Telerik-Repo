using System;

namespace DateDifferenceCalc
{
    class Program
    {
        static void Main()
        {
            DateTime startDate = DateTime.Parse("25.02.2006");
            DateTime endDate = DateTime.Parse("3.03.2106");
            DateDifference(startDate, endDate);
        }

        static void DateDifference(DateTime start, DateTime end)
        {
            Console.WriteLine("There are {0} days between dates", (end - start).Days);
        }
            
    }
}
