using System;
using System.Linq;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            int input3 = Convert.ToInt32(Console.ReadLine());

            int[] numbersArray = {input1 , input2 , input3};

            Console.WriteLine($"Largest number is {numbersArray.Max()}");
            Console.ReadKey();
        }
    }
}
