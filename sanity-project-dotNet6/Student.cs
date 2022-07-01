using System;
namespace sanity_project_csharp
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Student(int studentId, string name, string address, string city, string state)
        {
            StudentId = studentId;
            Name = name;
            Address = address;
            City = city;
            State = state;
        }
    }
}

