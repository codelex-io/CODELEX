using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;

            int sum = Convert.ToInt32(a) + b + c + (int)d + (int)e;
            Console.WriteLine(sum);
        }

        static void second()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            float sum = Convert.ToInt32(a) + b + c + (float)d + e;
            Console.WriteLine(sum);
        }
    }
}
