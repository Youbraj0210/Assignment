using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    internal class Student : Person
    {
        public string? Branch { get; set; }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {Id}, Name : {Name}  , DOB: {DOB.ToShortDateString()}, Address: {Address}, Branch: {Branch}");
        }
    }
}