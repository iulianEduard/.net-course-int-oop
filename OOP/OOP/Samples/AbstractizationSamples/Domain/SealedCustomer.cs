using System;

namespace OOP.Samples.AbstractizationSamples.Domain
{
    public sealed class SealedCustomer
    {
        public Guid Id { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
        }
    }
}
