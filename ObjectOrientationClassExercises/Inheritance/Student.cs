using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class Student  : Person
    {

        public string StudentNumber { get; set; }

        public string NqfLevel { get; set; }

        public string Course { get; set; }

        public string Institution { get; set; }

        public int Year { get; set; }

        public Student(string firstName, string surname, Gender gender, int age, Race race, bool deceased, string studentNumber, string nqfLevel, string course, string institution, int year) : base(firstName, surname, gender, age, race, deceased)
        {

            StudentNumber = studentNumber;
            NqfLevel = nqfLevel;
            Course = course;
            Institution = institution;
            Year = year;

        }
    

    }
}
