using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int lowerBound = 1;
            int upperBound = 100;
            
            for (int i = lowerBound; i <= upperBound; ++i)
            {
                sum += i;
            }

            decimal average = (decimal)sum / (decimal)upperBound;

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.WriteLine($"The average is {average}");
            Console.ReadKey();
        }
    }
}
