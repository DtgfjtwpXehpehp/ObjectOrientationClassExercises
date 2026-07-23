using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class Rectangle : Shape
    {
        private double length;
        private double breath;

        public Rectangle(double length,double breath )
        {
            this.length = length;
            this.breath = breath;
        }

        public override double GetArea()
        {
            return length * breath;
        }
    }
}
