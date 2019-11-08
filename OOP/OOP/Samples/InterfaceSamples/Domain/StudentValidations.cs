using FluentValidation;

namespace OOP.Samples.InterfaceSamples.Domain
{
    public class StudentValidations : AbstractValidator<Student>
    {
        public StudentValidations()
        {
            RuleFor(s => s.FirstName).NotNull().NotEmpty().MaximumLength(30);
            RuleFor(s => s.LastName).NotNull().NotEmpty().MaximumLength(40);
            RuleFor(s => s.Email).EmailAddress();
        }
    }
}
