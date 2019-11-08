using System;

namespace OOP.Samples.InterfaceSamples.Domain
{
    interface IStudentCreate
    {
        Student Handle(string firstName, string lastName, string email, string phone,
            Guid? assginToFacultyInYear);
    }
}
