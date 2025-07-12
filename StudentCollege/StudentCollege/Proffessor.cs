using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollege
{
    internal class Proffessor : Person
    {
        public string? Designation { get; set; }
        public int YearsOfExperience { get; set; }
        public double BaseSalary { get; set; }


        public double CalculateSalary()
        {
            double experienceBonus = 1000; 
            return BaseSalary + (YearsOfExperience * experienceBonus);
        }

        public void DisplayProfessorInfo()
        {
            Console.WriteLine($"Professor ID: {Id}, Name : {Name} , DOB: {DOB.ToShortDateString()},  Address: {Address}");
            Console.WriteLine($"Designation: {Designation}, Experience: {YearsOfExperience} years, Total Salary: {CalculateSalary()}");
        }
    }
}