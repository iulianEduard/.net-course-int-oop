using System;

namespace OOP.Samples.AbstractizationSamples.Domain
{
    public abstract class Customer
    {
        public Guid Id { get; set; }

        public abstract void Display();
    }
}
