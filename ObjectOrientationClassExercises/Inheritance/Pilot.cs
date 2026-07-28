using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class Pilot : Employee
    {

        public bool Licensed { get; set; }

        public double HoursFlown { get; set; }

        public FlyingType FlyingType { get; set; }
        public Pilot( string firstName,string surname, Gender gender, int age,Race race,bool deceased,string employeeNumber,decimal salary,string occupation,string company, string taxNumber, EmployementType employementType, bool licensed, double hoursFlown, FlyingType flyingType) : base(firstName, surname, gender, age, race, deceased, employeeNumber, salary, occupation, company, taxNumber, employementType)
        {
            Licensed = licensed;
            HoursFlown = hoursFlown;
            FlyingType = flyingType;
        }
    }
}
