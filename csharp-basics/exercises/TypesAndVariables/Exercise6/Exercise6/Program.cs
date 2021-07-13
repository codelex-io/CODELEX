using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter as many digits as you want (only digits): ");
                string input = Console.ReadLine();
                int sum = input.ToCharArray().Select(item => Convert.ToInt32(item.ToString())).ToArray().Sum();

                Console.WriteLine($"Sum of your entered numbers ir {sum}");
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }
    }
}