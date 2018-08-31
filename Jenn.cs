using System;

namespace dreamteam
{
    class Jenn : IStudent
    {
        public string Specialty { get; set; } = "React";
        public string FirstName { get; set; } = "Jenn";
        public string LastName { get; set; } = "Lawson";
        public string FullName =>  $"{FirstName} {LastName}";
        public void Work() => Console.WriteLine($"{FullName} likes working on {Specialty} because she's is hyper.");
    }
}