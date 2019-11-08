using OOP.Samples.InheritanceSamples.Domain;
using System;

namespace OOP.Samples.InheritanceSamples
{
    public class ChainingConstructors
    {
        public void Run()
        {
            DefaultConstructors();

            Console.WriteLine();

            CustomConstructors();
        }

        private void DefaultConstructors()
        {
            Console.WriteLine("Default constructors route");
            var studentJon = new Student
            {
                FirstName = "Jon",
                LastName = "Snow",
                InYear = 1,
                GroupId = 1
            };

            Console.WriteLine(studentJon.ToString());
        }

        private void CustomConstructors()
        {
            Console.WriteLine("Custom constructors route");
            var studentSansa = new Student(DateTime.Now.AddDays(-2))
            {
                FirstName = "Sansa",
                LastName = "Stark",
                InYear = 1,
                GroupId = 2
            };

            Console.WriteLine(studentSansa.ToString());
        }
    }
}