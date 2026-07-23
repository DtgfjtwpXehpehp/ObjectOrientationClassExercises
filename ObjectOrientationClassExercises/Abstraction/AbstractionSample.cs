using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Abstraction
{
    internal class AbstractionSample
    {
        public static void Run()
        {

            /* Shape shape= new Square(6);

             double areaOfSquare = shape.GetArea();

             Console.WriteLine($"The area of the square is: {areaOfSquare}");


             shape  = new Rectangle(2, 3);

             double areaOfRectangle = shape.GetArea();

             Console.WriteLine($"The area of the Rectangle is: {areaOfRectangle}");


             shape  = new Triangle(4, 6);

             double areaOfTriangle = shape.GetArea();

             Console.WriteLine($"The area of a Triangle is: {areaOfTriangle}");


             shape  = new Circle(6);

             double areaOfCicle = shape.GetArea();

             Console.WriteLine($"The area of a circle is: {Math.Round(areaOfCicle,3)}");*/

            List<Shape> toyBox = new List<Shape>();


            Shape toy = new Triangle(5, 10);

            toyBox.Add(toy);

            toy = new Square(8);

            toyBox.Add(toy);

            toy = new Rectangle(15, 8);

            toyBox.Add(toy);

            toy = new Circle(40);

            toyBox.Add(toy);

            toy = new Rhombus(80, 80);

            toyBox.Add(toy);

            toy = new FancyRhombus(new Triangle(10, 12));

            toyBox.Add(toy);

            double sum = 0;
            foreach (Shape shape in toyBox)
            {
                Console.WriteLine($"The area for a {shape.GetType().Name} is {shape.GetArea()}");


                sum += shape.GetArea();
            }




            Console.WriteLine($"The sum of the area of all the shapes is: {sum}");

        }
    
    }
}
