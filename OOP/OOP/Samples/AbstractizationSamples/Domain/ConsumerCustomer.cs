using System;

namespace OOP.Samples.AbstractizationSamples.Domain
{
    public class ConsumerCustomer : Customer
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Type { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Consumer customer: Id: {Id}, Name: {Name}, " +
                $"Address: {Address}, Email: {Email}, Type: {Type}");
        }
    }
}
