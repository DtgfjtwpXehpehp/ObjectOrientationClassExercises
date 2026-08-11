using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Cow : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Mooo");

            PlaySound("cow");
        }
    }
}
