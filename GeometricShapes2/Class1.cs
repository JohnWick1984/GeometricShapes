using System;

namespace GeometricShapesLibrary
{
    public class GeometricShapes
    {
        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double TriangleArea(double @base, double height)
        {
            return 0.5 * @base * height;
        }
    }
}