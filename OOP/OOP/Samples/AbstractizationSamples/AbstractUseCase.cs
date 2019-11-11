using OOP.Samples.AbstractizationSamples.Domain;
using System;

namespace OOP.Samples.AbstractizationSamples
{
    public class AbstractUseCase
    {
        public void Run()
        {
            /*
             * Abstract classes cannot be instanced
             */
            //var customer = new Customer();

            var consumerCustomer = new ConsumerCustomer
            {
                Address = "King's Landing",
                Email = "jon.snow@westeros.com",
                Id = Guid.NewGuid(),
                Name = "Jon Snow",
                Type = "Basic"
            };

            consumerCustomer.Display();

            var businessCustomer = new BusinessCustomer
            {
                Address = "Pentos",
                CUI = "12322322",
                Id = Guid.NewGuid(),
                Name = "Iron Bank",
                VAT = 21.0
            };

            businessCustomer.Display();
        }
    }
}
