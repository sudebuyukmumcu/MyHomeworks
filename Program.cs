using System;

namespace Inheritance
{
    //Inheritance
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="Engin"
                },
            new Student
            {
            FirstName = "Derin"
            },
            new Person
            {
            FirstName = "Salih"
            }
            //burada new person da olabilir.Çünkü
            //Interface tek başına bir şey ifade etmiyor.Ama classlarda person bir anlam ifade ediyor
            //tek başınada anlamlı inheritance verdiğimizde de anlamlı.
            //inheritance önce yazılır sonra interfaceler sırayla yazılabilir.
        };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer: Person //customerın ebeveyini person gibi düşünebiliriz. Çocuk babasına ait özellikleri taşıyabilir ve ek olarakta özellikleri olabilir.
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }

    }

