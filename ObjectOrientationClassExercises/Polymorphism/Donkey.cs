using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal class Donkey : Animal 
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Yeehaw");

            PlaySound("donkey");
        }
    }
}
