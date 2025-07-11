using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulation
{
    internal class Student
    {
        private int rollNo;
        private string name;
        private double cgpa;

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                    rollNo = value;
                else
                    rollNo = 0;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 5)
                    name = value;
                else
                    name = "";
            }
        }

        public double Gpa
        {
            get { return cgpa; }
            set
            {
                if (value >= 1 && value <= 10)
                    cgpa = value;
                else
                    cgpa = 0;
            }
        }

        public double GetPercentage()
        {
            return cgpa * 9.5;
        }

        public override string ToString()
        {
            return $"Roll No           : {RollNo}\n" +
                   $"Name:             : {(string.IsNullOrEmpty(Name) ? "Invalid Name" : Name)}\n" +
                   $"CGPA              : {cgpa}\n" +
                   $"Percentage        : {GetPercentage()}";
        }
    }
}
