using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Person : Animal
    {
        public override void MakeNoise()
        {

            Console.WriteLine("Blah blah blah");

            PlaySound("person");

        }
    }
}
