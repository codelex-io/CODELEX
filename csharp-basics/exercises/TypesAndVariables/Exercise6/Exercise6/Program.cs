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
                char[] inputCharArray = input.ToCharArray();
                bool isDigits = true;

                for(int i = 0; i < inputCharArray.Length; i++)
                {
                    if(!Char.IsDigit(inputCharArray[i]))
                    {
                        isDigits = false;
                    }
                }

                if(isDigits)
                {
                    int sum = inputCharArray.Select(item => Convert.ToInt32(item.ToString())).ToArray().Sum();

                    Console.WriteLine($"Sum of your entered numbers ir {sum}");
                } else
                {
                    Console.WriteLine("Wrong input!!! Only digits allowed!");
                }

                Console.WriteLine("------------------------------------------------------------------------");
            }
        }
    }
}