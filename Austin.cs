using System;

namespace dreamteam
{
    class Austin : IStudent
    {
        public string Specialty { get; set; } = "CSS";
        public string FirstName { get; set; } = "Austin";
        public string LastName { get; set; } = "Gorman";
        public string FullName =>  $"{FirstName} {LastName}";
        public void Work() => Console.WriteLine($"{FullName} is a {Specialty} specialist because he is a graphic designer who hates design.");
    }
}