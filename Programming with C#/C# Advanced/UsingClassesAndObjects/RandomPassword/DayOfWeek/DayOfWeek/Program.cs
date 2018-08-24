using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime todayDate = DateTime.Now;

            Console.WriteLine("Today is {0}", todayDate.DayOfWeek);
            Console.WriteLine("Today is {0} {1}", todayDate.Day, todayDate.Month);
        }
    }
}
