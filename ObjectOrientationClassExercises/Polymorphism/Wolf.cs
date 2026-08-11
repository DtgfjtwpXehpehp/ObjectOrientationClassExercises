using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Wolf : Dog
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Awoooo");

            PlaySound("wolf");
        }
    }
}