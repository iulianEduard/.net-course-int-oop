using System;

namespace OOP.Samples.PolymorphismSamples.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }

        public virtual void Display()
        {
            Console.WriteLine("This is from Customer class!");
        }
    }
}
