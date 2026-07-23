using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class FancyRhombus : Shape
    {
        private Shape triangle;
        


        public FancyRhombus(Triangle triangle)
        {
            this.triangle = triangle;
        }

        public override double GetArea()
        {
            return 2 * triangle.GetArea();
        }
    }
}
