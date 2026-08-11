using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Lion : Animal
    {

      

        public override void MakeNoise()
        {
            Console.WriteLine("Roar");

            PlaySound("lion");

        }
    }
}
