using ObjectOrientationClassExercises.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Interfaces
{
    internal class Goblin : GameCharacter
    {
        public Goblin(int health, int gold, string firstName, string surname, Gender gender, int age, Race race, bool deceased) : base(health, gold, firstName, surname, gender, age, race, deceased)
        {

        }

        public void Attack()
        {

        }
    }
}
