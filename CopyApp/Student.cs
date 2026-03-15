using System;
using System.Collections.Generic;
using System.Text;

namespace CopyApp
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public Address Address { get; set; }

        // Copy constructor
        public Student(Student student)
        {
            Id = student.Id;
            Firstname = student.Firstname;
            Lastname = student.Lastname;
            // Address = student.Address; // Shallow copy of the reference thod Address object
            Address = new Address
            {
                Street = student.Address?.Street,
                Number = student.Address?.Number,
                ZipCode = student.Address?.ZipCode
            };
        }
    }
}
