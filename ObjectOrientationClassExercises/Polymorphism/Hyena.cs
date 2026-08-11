using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Hyena : Animal
    {
        public override void MakeNoise()
        {

            //base.MakeNoise();
            Console.WriteLine("Hahaha");

            PlaySound("hyena");
        }
    }
}
