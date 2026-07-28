using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class Person
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public Race Race { get; set; }

        public bool Deceased { get; set; }


        //public string FullName { get; set; }
        public  string FullName
        {
            get { return $"{FirstName} {Surname}"; }
            //set { FullName = value; }
        }


        public Person(string firstName, string surname, Gender gender, int age, Race race, bool deceased)
        {
             FirstName = firstName;
             Surname = surname;
             Gender = gender;
             Age = age;
             Race = race;
             Deceased = deceased;
        }





    }
}
