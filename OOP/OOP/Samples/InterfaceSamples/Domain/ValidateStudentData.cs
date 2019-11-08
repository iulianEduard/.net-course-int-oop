using System;

namespace OOP.Samples.InterfaceSamples.Domain
{
    public class ValidateStudentData
    {
        public void Handle(Student student)
        {
            var validator = new StudentValidations();
            var result = validator.Validate(student);

            if(!result.IsValid)
            {
            }
        }
    }
}
