using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2P1.Shapes
{
    class Rhombus : Shape
    {
        double side;
        double angle;

        public Rhombus(double side, double angle)
        {
            this.side = side;
            this.angle = angle;
        }

        public double getPerimeter()
        {
            return side * 4;
        }

        public double getArea()
        {
            return side * side * Math.Sin(angle);
        }

    }
}
