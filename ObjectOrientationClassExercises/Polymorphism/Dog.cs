using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Dog : Animal
    {
        public override void MakeNoise()
        {
            //base.MakeNoise();
            Console.WriteLine("Woof");

            PlaySound("dog");
        }
    }
}
