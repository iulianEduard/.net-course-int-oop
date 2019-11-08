using System;

namespace OOP.Samples.PolymorphismSamples.Domain
{
    public abstract class Customer
    {
        public Guid Id { get; set; }

        public abstract void Display();
    }
}
