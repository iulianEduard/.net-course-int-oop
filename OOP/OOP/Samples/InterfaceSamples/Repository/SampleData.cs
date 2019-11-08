using OOP.Samples.InterfaceSamples.Domain;
using System.Collections.Generic;

namespace OOP.Samples.InterfaceSamples.Repository
{
    public static class SampleData
    {
        private static List<Student> _students;


        public static List<Student> GetStudents()
        {
            _students = new List<Student>();

            return _students;
        }

        public static void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}
