using System;

namespace dreamteam
{
    class Evan : IStudent
    {
        public string Specialty { get; set; } = "Neuroanalytic Machine Learnifications";
        public string FirstName { get; set; } = "Evan";
        public string LastName { get; set; } = "Lusky";
        public string FullName =>  $"{FirstName} {LastName}";
        public void Work() => Console.WriteLine($"{FullName} is a {Specialty} specialist because he uses big words to describe things.");
    }
}