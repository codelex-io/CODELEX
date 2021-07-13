using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data");

            Console.Write("Enter distance in meters: ");
            int distanceInMeters = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            int allTimeSumInSeconds = (hours * 3600) + (minutes * 60) + seconds;
            double allTimeSumInHour = (double)hours + ((double)minutes / 60) + ((double)seconds / 3600);
            double distanceInKilometers = (double)distanceInMeters / 1000;
            double speedInMetersPerSeconds = (double)distanceInMeters / (double)allTimeSumInSeconds;
            double speedInKilometersPerHour = (double)distanceInKilometers / (double)allTimeSumInHour;
            double speedInMilesPerHour = (double)distanceInMeters / 1609 / allTimeSumInHour;

            Console.WriteLine($"Your speed in meters/second is {speedInMetersPerSeconds.ToString("0.00000000")}");
            Console.WriteLine($"Your speed in km/h is {speedInKilometersPerHour.ToString("0.00000000")}");
            Console.WriteLine($"Your speed in miles/h is {speedInMilesPerHour.ToString("0.00000000")}");
            Console.ReadKey();
        }
    }
}
