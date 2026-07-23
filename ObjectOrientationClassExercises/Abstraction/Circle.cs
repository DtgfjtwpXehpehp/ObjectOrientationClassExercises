using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * (radius * radius);
        }
    }
}
