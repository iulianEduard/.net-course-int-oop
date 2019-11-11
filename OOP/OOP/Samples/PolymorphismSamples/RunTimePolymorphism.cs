using OOP.Samples.PolymorphismSamples.Domain;
using System;

namespace OOP.Samples.PolymorphismSamples
{
    public class RunTimePolymorphism
    {
        public void Run()
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid()
            };
            customer.Display();

            var consumerCustomer = new ConsumerCustomer
            {
                Id = Guid.NewGuid(),
                Address = "Pentos",
                Email = "greyworm@westeros.com",
                Name = "Grey Worm",
                Type = "Standard"
            };
            consumerCustomer.Display();

            var businessCustomer = new BusinessCustomer
            {
                Id = Guid.NewGuid(),
                Address = "Pentos",
                Name = "Iron Bank",
                CUI = "3654588",
                VAT = 10.2
            };
            businessCustomer.Display();
        }
    }
}
