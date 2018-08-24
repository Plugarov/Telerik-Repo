using System;

namespace HelloC
{
    class Program
    {
        static void Main()
        {
            var userInput = Console.ReadLine();
            var currentDate = DateTime.Now.Date;
            DateTime userDate = DateTime.ParseExact(userInput, "dd-MM-yyyy", null).Date;

            var year = currentDate.Year - userDate.Year;
            var month = currentDate.Month - userDate.Month;
            var days = currentDate.Day - userDate.Day;

            Console.WriteLine(1); 
        }
    }
}
