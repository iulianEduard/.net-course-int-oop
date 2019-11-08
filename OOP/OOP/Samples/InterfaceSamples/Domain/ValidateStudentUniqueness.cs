using OOP.Samples.InterfaceSamples.Repository;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Samples.InterfaceSamples.Domain
{
    public class ValidateStudentUniqueness
    {
        public bool Handle(string firstName, string lastName, string email)
        {
            var students = GetStudents();

            var isUnique = IsUnique(students, firstName, lastName, email);

            return isUnique;
        }

        private List<Student> GetStudents()
        {
            return SampleData.GetStudents();
        }

        private bool IsUnique(List<Student> students, string firstName, string lastName, string email)
        {
            var foundStudent = students.Where(s => s.FirstName.ToLower() == firstName.ToLower()
                && s.LastName.ToLower() == lastName.ToLower()
                && s.Email.ToLower() == email.ToLower()).FirstOrDefault();

            return foundStudent == null ? true : false;
        }
    }
}
