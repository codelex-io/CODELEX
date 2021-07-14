using System;

namespace Exercise4
{
    class Program
    {
        static void PrintDayInWord(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesdey");
                    break;
                case 4:
                    Console.WriteLine("Thurday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }
        }

        static void Main(string[] args)
        {
            PrintDayInWord(7);
            Console.ReadKey();
        }
    }
}
