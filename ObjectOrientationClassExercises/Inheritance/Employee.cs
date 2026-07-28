using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class Employee : Person
    {

        public string EmployeeNumber { get; set; }

        public decimal Salary { get; set; }

        public string Occupation { get; set; }

        public string Company { get; set; }

        public string TaxNumber { get; set; }

        public EmployementType EmployementType { get; set; }
       

        public Employee(string firstName, string surname, Gender gender, int age, Race race, bool deceased, string employeeNumber, decimal salary, string occupation,string company, string taxNumber, EmployementType employementType) : base(firstName, surname, gender, age, race, deceased)
        {
            EmployeeNumber = employeeNumber;
            Salary = salary;
            Occupation = occupation;
            Company = company;
            TaxNumber = taxNumber;
            EmployementType = employementType;
        }

      
    }
}
