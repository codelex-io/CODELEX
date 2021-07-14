using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(double radius)
        {
            return Math.PI * radius * 2;
        }

        public static double areaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double areaOfTriangle(double ground, double height)
        {
           return ground* height * 0.5;
        }
    }
}
