using System;

namespace Module7IntroductoryLinq
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public double GPA { get; set; }

        // Optional: helpful display property
        public string FullName => $"{FirstName} {LastName}";
    }
}
