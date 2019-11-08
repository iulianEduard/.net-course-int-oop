using System;

namespace OOP.Samples.InterfaceSamples.Domain
{
    public class Student
    {
        public Guid Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Guid? FacultyYearId { get; set; }

        public Student()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"--> Student: Id = {Id}, First Name = {FirstName}, Last Name = {LastName}, Email = {Email}, Phone = {Phone}";
        }
    }
}
