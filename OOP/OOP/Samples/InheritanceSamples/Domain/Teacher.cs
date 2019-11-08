using System;

namespace OOP.Samples.InheritanceSamples.Domain
{
    public class Teacher : Enlisted
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int[] TeachesForYears { get; set; }

        public Teacher()
        {
            Console.WriteLine("*** Teacher -> default constructor ***");
            Console.WriteLine(Environment.NewLine);
        }

        public Teacher(DateTime createdDate) : base(createdDate)
        {
            Console.WriteLine("*** Teacher -> custom constructor ***");
            Console.WriteLine(Environment.NewLine);
        }

        public override string ToString()
        {
            return $"Teacher: Id = {Id}, First name = {FirstName}, Last name = {LastName}";
        }
    }
}
