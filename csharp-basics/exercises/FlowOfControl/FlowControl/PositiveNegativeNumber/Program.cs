﻿using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input > 0)
            {
                Console.WriteLine("Number is positive");
            } 
            else if(input < 0) 
            {
                Console.WriteLine("Number is negative");
            } 
            else 
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadKey();
        }
    }
}
