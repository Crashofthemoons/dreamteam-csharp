using System;

namespace dreamteam
{
    class Jacob : IStudent
    {
        public string Specialty { get; set; } = "C#";
        public string FirstName { get; set; } = "Jacob";
        public string LastName { get; set; } = "Henderson";
        public string FullName =>  $"{FirstName} {LastName}";
        public void Work() => Console.WriteLine($"{FullName} is a {Specialty} specialist because he got himself some school'n.");
    }
}