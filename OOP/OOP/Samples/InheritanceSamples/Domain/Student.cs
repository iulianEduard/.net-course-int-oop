using System;

namespace OOP.Samples.InheritanceSamples.Domain
{
    public class Student : Enlisted
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int InYear { get; set; }

        public int GroupId { get; set; }

        public Student()
        {
            Console.WriteLine("*** Student -> default constructor ***");
            Console.WriteLine(Environment.NewLine);
        }

        /*
         * If we want to call a diferent constructor from base class
         * not the default one, this is how we do it.
         */
        public Student(DateTime customDate) : base(customDate)
        {
            Console.WriteLine("*** Student -> custom constructor ***");
            Console.WriteLine(Environment.NewLine);
        }

        public override string ToString()
        {
            return $"--> Student: Id: {Id}, First name: {FirstName}, Last name: {LastName}, Enlisted date: {CreatedDate}";
        }
    }
}
