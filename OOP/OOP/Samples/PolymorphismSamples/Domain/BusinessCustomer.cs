using System;

namespace OOP.Samples.PolymorphismSamples.Domain
{
    public class BusinessCustomer : Customer
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string CUI { get; set; }

        public double? VAT { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Business Customer: Id: {Id}, Name: {Name}, Address: {Address}" +
                $" CUI: {CUI}, VAT: {VAT}");
        }
    }
}
