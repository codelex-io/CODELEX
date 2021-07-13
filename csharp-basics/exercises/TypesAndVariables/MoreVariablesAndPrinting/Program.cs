using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Zed A. Shaw";
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            int age = 35;
            int heightInInches = 74;
            int weightInLbs = 180;
            double heightInCentimeters = heightInInches * 2.54;
            double weightInKilos = 180 * 0.453592;
            double ageHeightWeightSum = age + heightInCentimeters + weightInKilos;

            Console.WriteLine($"Let's talk about {name}.");
            Console.WriteLine($"He's {heightInCentimeters.ToString("0.00")} centimeters tall.");
            Console.WriteLine($"He's {weightInKilos.ToString("0.00")} kilos heavy.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"He's got {eyes} eyes and {hair} hair.");
            Console.WriteLine($"His teeth are usually {teeth} depending on the coffee.");

            Console.WriteLine($"If I add {age}, {heightInCentimeters.ToString("0.00")}, and {weightInKilos.ToString("0.00")} I get {ageHeightWeightSum.ToString("0.00")}.");

            Console.ReadKey();
        }
    }
}