using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.Write("Input an integer number less than ten billion: ");
            long input = Convert.ToInt64(Console.ReadLine());


            if (input.GetType() == typeof(long)) 
            {
                if (input < 0) 
                {
                    input *= -1;
                }

                if (input >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    string numberToString = input.ToString();

                    Console.WriteLine($"Number of digits in the number: {numberToString.Length}");
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadKey();
        }
    }
}
