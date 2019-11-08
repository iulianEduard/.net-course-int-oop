using OOP.Samples.InheritanceSamples.Domain;
using System;

namespace OOP.Samples.InheritanceSamples
{
    public class MultilevelInheritance
    {
        public void Run()
        {
            var employee = new Employee()
            {
                FirstName = "Bron",
                LastName = "Blackwater"
            };

            Console.WriteLine(employee.ToString());
        }
    }
}
