using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2P1.Shapes
{
    class Trapeze : Shape
    {
        double sideA;
        double sideB;
        double sideC;
        double sideD;

        public Trapeze(double A, double B, double C, double D)
        {
            this.sideA = A;
            this.sideB = B;
            this.sideC = C;
            this.sideD = D;
        }

        public double getPerimeter()
        {
            return sideA + sideB + sideC + sideC;
        }

        public double getArea()
        {
            return ((sideA+sideB)/(sideA-sideB)) * 
                   Math.Sqrt(sideA-sideB+sideC+sideD) * 
                   Math.Sqrt(sideA - sideB - sideC + sideD) * 
                   Math.Sqrt(sideA - sideB + sideC - sideD) * 
                   Math.Sqrt(-sideA + sideB + sideC + sideD) / 4;
        }
    }
}
