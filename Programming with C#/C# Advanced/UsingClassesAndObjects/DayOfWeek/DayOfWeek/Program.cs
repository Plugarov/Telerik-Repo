using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main()
        {
            DateTime dayOfWeek = DateTime.Now;
            Console.WriteLine(dayOfWeek.DayOfWeek);
            Console.WriteLine(dayOfWeek.AddYears(5));
            Console.WriteLine(dayOfWeek.ToShortDateString());
            Console.WriteLine(dayOfWeek.ToUniversalTime());
            Console.WriteLine(dayOfWeek.ToOADate());
        }
    }
}
