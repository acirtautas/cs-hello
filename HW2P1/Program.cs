using System;

namespace HW2P1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var circle   = new Shapes.Circle(10);
            var square   = new Shapes.Square(10);
            var triangle = new Shapes.Triangle(10, 10, 10);
            var rhombus  = new Shapes.Rhombus(10, 90);
            var trapeze  = new Shapes.Trapeze(10, 10, 10, 10);
        }
    }
}
