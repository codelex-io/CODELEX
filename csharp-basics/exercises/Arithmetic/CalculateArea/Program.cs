using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = getMenu();

                if (choice == 1)
                {
                    Console.WriteLine("You chose 1");
                    calculateCircleArea();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose 2");
                    calculateRectangleArea();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("You chose 3");
                    calculateTriangleArea();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Press any key.");
                Console.ReadKey();

            } while (choice != 4);
        }

        public static int getMenu()
        {
            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            string input = Console.ReadLine();

            userChoice = Convert.ToInt32(input);

            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                input = Console.ReadLine();

                if(userChoice >= 1 || userChoice <= 4)
                {
                    break;
                }
            }

            return userChoice;
        }

        public static void calculateCircleArea()
        {
            Console.Write("What is the circle's radius: ");
            string input = Console.ReadLine();
            double radius = Convert.ToDouble(input);

            Console.WriteLine("The circle's area is "
                    + Geometry.areaOfCircle(radius).ToString("0.000"));
        }

        public static void calculateRectangleArea()
        {
            Console.Write("Enter length: ");
            string inputLength = Console.ReadLine();
            double length = Convert.ToDouble(inputLength);

            Console.Write("Enter width: ");
            string inputWidth = Console.ReadLine();
            double width = Convert.ToDouble(inputWidth);

            Console.WriteLine("The rectangle's area is "
                    + Geometry.areaOfTriangle(length, width));
        }

        public static void calculateTriangleArea()
        {
            Console.Write("Enter length of the triangle's base: ");
            string inputLength = Console.ReadLine();
            double ground = Convert.ToDouble(inputLength);

            Console.Write("Enter triangle's height: ");
            string inputHeight = Console.ReadLine();
            double height = Convert.ToDouble(inputHeight);

            Console.WriteLine("The triangle's area is "
                    + Geometry.areaOfRectangle(ground, height));
        }
    }
}
