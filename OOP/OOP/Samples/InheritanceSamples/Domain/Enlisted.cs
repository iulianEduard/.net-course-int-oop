using System;

namespace OOP.Samples.InheritanceSamples.Domain
{
    public class Enlisted
    {
        protected Guid Id { get; }

        public DateTime CreatedDate { get; set; }

        public Enlisted()
        {
            Console.WriteLine("*** Enlisted -> default constructor ***");
            Console.WriteLine(Environment.NewLine);

            CreatedDate = DateTime.Now;
            Id = Guid.NewGuid();
        }

        public Enlisted(DateTime date)
        {
            Console.WriteLine("*** Enlisted -> custom constructor ***");
            Console.WriteLine(Environment.NewLine);

            CreatedDate = date;
            Id = Guid.NewGuid();
        }
    }
}
