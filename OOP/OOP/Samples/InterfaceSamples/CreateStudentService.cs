using OOP.Samples.InterfaceSamples.Domain;
using OOP.Samples.InterfaceSamples.Repository;
using System;

namespace OOP.Samples.InterfaceSamples
{
    public class CreateStudentService : IStudentCreate
    {
        public Student Handle(string firstName, string lastName, string email, string phone, Guid? assginToFacultyInYear)
        {
            var isUnique = new ValidateStudentUniqueness().Handle(firstName, lastName, email);

            if (!isUnique)
            {
                throw new Exception("Student data not unique!");
            }

            var student = Init(firstName, lastName, email, phone, assginToFacultyInYear);

            new ValidateStudentData().Handle(student);

            Save(student);

            return student;
        }

        private Student Init(string firstName, string lastName, string email, string phone, Guid? assginToFacultyInYear)
        {
            return new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = email,
                FacultyYearId = assginToFacultyInYear
            };
        }

        private void Save(Student student)
        {
            SampleData.AddStudent(student);
        }
    }
}
