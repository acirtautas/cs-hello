using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2P1.Shapes
{
    class Square : Shape
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double getPerimeter()
        {
            return side*4;
        }

        public double getArea()
        {
            return side*side;
        }
    }
}
