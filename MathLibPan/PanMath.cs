using System;

namespace MathLibPan
{
    public class PanMath
    {
        // Circle methods
        public double CirclePerimeter(double radius)
        {
            double perimeter = 2 * Math.PI * radius;

            return perimeter;
        }

        public double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        public double CircleDiameter(double radius)
        {
            double diameter = radius * 2;

            return diameter;
        }


        // Triangle methods
        public double TrianglePerimeter(double sideA, double sideB, double sideC)
        {
            double perimeter = sideA + sideB + sideC;

            return perimeter;
        }

        public double TriangleArea(double sideA, double sideB, double sideC)
        {
            double p = TrianglePerimeter(sideA, sideB, sideC) / 2;
            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            return area;
        }

        public double TriangleHeight(double sideA, double sideB)
        {
            double height = sideA * sideB / 2;

            return height;
        }

        // Rectangle methods
        public  double RectangularPerimeter(double sideA, double sideB)
        {
            double perimeter = 2 * (sideA + sideB);
            return perimeter;
        }

        public  double RectangularArea(double sideA, double sideB)
        {
            double area = sideA * sideB;

            return area;
        }

        public double RectangularDiagonal(double sideA, double sideB)
        {
            double diagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return diagonal;
        }
    }
}
