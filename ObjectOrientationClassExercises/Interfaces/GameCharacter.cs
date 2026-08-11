using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientationClassExercises.Inheritance;

namespace ObjectOrientationClassExercises.Interfaces
{
    internal class GameCharacter : Person , IDamagable, ILootable
    {
        public int Health { get; set; }

        public int Gold { get; set; }



        public GameCharacter(int health, int gold, string firstName, string surname, Gender gender, int age, Race race, bool deceased) : base(firstName, surname, gender, age, race, deceased)
        {
            Health = health;
            Gold = gold;

        }

        public void Attack()
        {
            //Health--;

            var random = new Random();

            int healthToDecrease = random.Next(50);


            if(Health>= healthToDecrease)
            {
                Health -= healthToDecrease;

            }
            else
            {
                Health = 0;

                Deceased = true;
            }

        }

        public void Steal()
        {
            var random = new Random();

            int goldToSteal = random.Next(10);

            //Gold -= goldToSteal;

            if (Gold >= goldToSteal)
            {
                Gold -= goldToSteal;

            }
            else
            {
                Gold = 0;

                //Deceased = true;
            }

        }
    }
}
