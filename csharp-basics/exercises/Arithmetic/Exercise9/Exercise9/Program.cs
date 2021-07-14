using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight, kg: ");
            double inputWeight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height, cm: ");
            double inputHeight = double.Parse(Console.ReadLine());

            double weightToPounds = inputWeight * 2.205;
            double heightToInches = inputHeight * 0.394;
            double bmi = weightToPounds * 703 / Math.Pow(heightToInches, 2);

            if(bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine("Your weight is optimal");
            } else if (bmi < 18.5)
            {
                Console.WriteLine("Your are underweight");
            } else
            {
                Console.WriteLine("Your are overweight");
            }

            Console.ReadKey();
        }
    }
}
