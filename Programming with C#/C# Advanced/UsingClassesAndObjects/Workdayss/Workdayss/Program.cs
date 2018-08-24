using System;
using System.Collections.Generic;

namespace Workdayss
{
    class Program
    {
        private static List<DateTime> publicHolydays;

        static void Main()
        {
            Console.WriteLine("Please enter last working in format DD.MM.YYYY .");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            DateTime currentDate = DateTime.Today;

            calculateWorkingDays(date, currentDate);
        }

        private static void calculateWorkingDays(DateTime date, DateTime currentDate)
        {
            int countHolidays = 0;
            int countDays = 0;
            int countWeekends = 0;
            int countAllDays = 0;

            int currentYear = DateTime.Now.Year;

            publicHolydays = new List<DateTime>() { new DateTime(currentYear, 1, 1),
                new DateTime(currentYear, 3, 2), new DateTime(currentYear, 3, 3),
                new DateTime(currentYear, 4, 10), new DateTime(currentYear, 4, 11),
                new DateTime(currentYear, 4, 12), new DateTime(currentYear, 4, 13),
                new DateTime(currentYear, 5, 1), new DateTime(currentYear, 5, 6),
                new DateTime(currentYear, 9, 21), new DateTime(currentYear, 9, 22),
                new DateTime(currentYear, 12, 24), new DateTime(currentYear, 12, 25),
                new DateTime(currentYear, 12, 26), new DateTime(currentYear, 12, 31),};

            while (currentDate <= date)
            {
                if (publicHolydays.Contains(currentDate))
                {
                    countHolidays++;
                }
                else if ((int)currentDate.DayOfWeek == 6 || (int)currentDate.DayOfWeek == 0)
                {
                    countWeekends++;
                }
                else
                {
                    countDays++;
                }
                currentDate = currentDate.AddDays(1);
            }
            Console.WriteLine("Holydays: {0} WorkingDays: {1} Weekends: {2}", countHolidays, countDays, countWeekends);
            Console.WriteLine(countAllDays + " " + currentYear);
        }   

    }
}
