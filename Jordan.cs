using System;

namespace dreamteam
{
    class Jordan : IStudent
    {
        public string Specialty { get; set; } = "Java";
        public string FirstName { get; set; } = "Jordan";
        public string LastName { get; set; } = "Williams";
        public string FullName =>  $"{FirstName} {LastName}";
        public void Work() => Console.WriteLine($"{FullName} is a {Specialty} specialist because he is a farm boy.");
    }
}