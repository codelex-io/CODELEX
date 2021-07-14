using System;

namespace Exercise4
{
    class Program
    {
        static void Product1ToN()
        {
            int number = 10;
            int factorial = 1;

            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is: {factorial}");
        }

        static void Main(string[] args)
        {
            Product1ToN();
            Console.ReadKey();
        }
    }
}
