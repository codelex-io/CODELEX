using System;

namespace Exercise1
{
    class Program
    {
        static bool CheckNumbers(int a, int b)
        {
            return a == 15 || b == 15 || a + b == 15 || a - b == 15 || b - a == 15;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckNumbers(30, 15));
            Console.ReadKey();
        }
    }
}
