using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Inheritance
{
    internal class InheritanceSample
    {
        public  static void Run()
        {
            List<Person> people = new List<Person>();

            Person person = new Person("Sivuyile", "Mtwetwe", Gender.Male,26,  Race.African, false);

            people.Add(person);

            Student student = new Student("Samantha", "Pieterse", Gender.Female, 22, Race.White, false, "501920", "8", "CompSci", "UWC", 5);

            people.Add(student);

            Employee employee = new Employee("Elon", "Musk", Gender.Male, 46, Race.White, true,"12345",30000000, "dev","BitCoin Inc", "A1002",EmployementType.FullTime);

            people.Add(employee);

            Pilot pilot = new Pilot("Simone", "Nina", Gender.Female, 45, Race.Colored, false, "12345", 980000000, "programmer", "US Spaceforce Inc", "A1002", EmployementType.Contract, true, 10, FlyingType.Fighter);

            people.Add(pilot);

            foreach (Person singlePerson in people)
            {
                if(!singlePerson.Deceased && singlePerson.Age > 30)
                {

            Console.WriteLine($"FullName: {singlePerson.FullName}");
                }

                
            }


            foreach (Person singlePerson in people)
            {
                if(singlePerson is Employee)
                {
                    Employee singleEmployee = singlePerson as Employee;

                    if (singleEmployee.EmployementType == EmployementType.FullTime)
                    {
                        Console.WriteLine($"FullName {singleEmployee.FullName}");
                    }
                }

               
                
            }


            foreach (Person singlePerson in people)
            {

                if(singlePerson is Student)
                {
                    Student singleStudent = singlePerson as Student;

                    Console.WriteLine($"FullName: {singleStudent.FullName} Student Number: {singleStudent.StudentNumber}");
                }
                
            }

        }

    }
}
