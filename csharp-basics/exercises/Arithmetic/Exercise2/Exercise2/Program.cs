using System;

namespace Exercise2
{
    class Program
    {
        static void CheckOddEven(int a)
        {
            if(a % 2 == 0)
            {
                Console.WriteLine("Even Number");
            } 
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine("Bye");
        }

        static void Main(string[] args)
        {
            CheckOddEven(19);
            Console.ReadKey();
        }
    }
}
