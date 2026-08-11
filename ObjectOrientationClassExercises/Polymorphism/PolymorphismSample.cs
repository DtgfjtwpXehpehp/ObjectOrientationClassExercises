using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Polymorphism
{
    internal  class PolymorphismSample
    {
        public static void Run()
        {
            List<Animal> zoo = new List<Animal>();

            Animal animal = new Dog();
            //animal.MakeNoise();
            zoo.Add(animal);

            animal = new Cow();
            //charlie.MakeNoise();
            zoo.Add(animal);

            animal = new Hyena();
            //kruger.MakeNoise();
            zoo.Add(animal);

            animal = new Wolf();
            zoo.Add(animal);

            animal = new Lion();
            zoo.Add(animal);

            animal = new Donkey();
            zoo.Add(animal);

            animal = new Person();

            zoo.Add(animal);

            foreach(Animal cagedAnimal in zoo)
            {

                Console.Write($"A {cagedAnimal.GetType().Name} makes a ");
                cagedAnimal.MakeNoise();

                Thread.Sleep(3000);
            }




        }
    }
}
