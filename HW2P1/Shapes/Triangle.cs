using System;

namespace HW2P1.Shapes
{
    class Triangle : Shape
    {
        double sideA;
        double sideB;
        double sideC;

        public Triangle(double A, double B, double C)
        {
            this.sideA = A;
            this.sideB = B;
            this.sideC = C;
        }

        public double getPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public double getArea()
        {
            double p = getPerimeter() / 2;

            return Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
        }
    }
}
