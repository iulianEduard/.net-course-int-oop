using System;

namespace OOP.Samples.InheritanceSamples.Domain
{
    public class Employee : Teacher
    {
        public Guid EmpId { get; set; }

        public string AccessCode { get; }

        public Employee()
        {
            Console.WriteLine("*** Employee -> custom constructor ***");
            Console.WriteLine(Environment.NewLine);

            EmpId = Guid.NewGuid();
            AccessCode = GenerateAccessCode();
        }

        public override string ToString()
        {
            return $"Employee: EmpId: {EmpId}, EnlistId: {Id}, First Name = {FirstName}, Last Name = {LastName}, Access Code = {AccessCode}";
        }

        private string GenerateAccessCode()
        {
            var random = new Random();
            var generatedNumbersArray = new double[3];

            for(int i = 1; i <= 3; i++)
            {
                int min = Convert.ToInt32(Math.Pow(10, i));
                int max = Convert.ToInt32(Math.Pow(99, i));

                var number = random.Next(min, max);
                generatedNumbersArray[i - 1] = number;
            }

            var accessCode = string.Empty;
            foreach(var generatedNumber in generatedNumbersArray)
            {
                accessCode += generatedNumber.ToString();
            }

            return accessCode;
        }
    }
}
