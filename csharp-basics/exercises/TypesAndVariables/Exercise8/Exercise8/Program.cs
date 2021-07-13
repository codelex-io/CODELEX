using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 30;
            int minutesInHour = 60;
            int hoursInDay = 24;
            int daysInYear = 365;
            double minutesToDays = (double)minutes / minutesInHour / hoursInDay;
            decimal minutesToYears = (decimal)minutesToDays / daysInYear;

            Console.WriteLine($"{minutes} are {minutesToDays} days and {minutesToYears} of year.");
            Console.ReadKey();
        }
    }
}
