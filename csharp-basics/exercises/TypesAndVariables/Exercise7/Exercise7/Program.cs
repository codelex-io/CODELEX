using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            int uppercaseLettersCount = input.Count(item => Char.IsUpper(item));

            Console.WriteLine($"Uppercase letters count is {uppercaseLettersCount}");
            Console.ReadKey();
        }
    }
}
