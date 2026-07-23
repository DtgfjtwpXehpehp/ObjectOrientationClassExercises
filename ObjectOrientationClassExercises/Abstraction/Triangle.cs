using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class Triangle: Shape
    {
        private double baseOfTriangle;
        private double hieght;

        public Triangle(double baseOfTriangle, double hieght)
        {
            this.baseOfTriangle = baseOfTriangle;
            this.hieght = hieght;
        }

        public override double GetArea()
        {
            return (0.5* baseOfTriangle) * hieght;
        }
    }
}
