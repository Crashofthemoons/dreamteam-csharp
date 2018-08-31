using System;

namespace dreamteam
{
    class Brett : IStudent
    {
        public string Specialty { get; set; } = "JSON";
        public string FirstName { get; set; } = "Brett";
        public string LastName { get; set; } = "Shearin";
        public string FullName =>  $"{FirstName} {LastName}";
        public void Work() => Console.WriteLine($"{FullName} is a {Specialty} specialist because he is a young stallion.");
    }
}