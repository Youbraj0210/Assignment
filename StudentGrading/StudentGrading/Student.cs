using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrading
{
    internal class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public char Grade { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }

        public Student(string name, int marks, char grade)
        {
            Name = name;
            Marks = marks;
            Grade = grade;
        }

        public static void AssignGrade(Student obj)
        {
            if (obj.Marks >= 90)
                obj.Grade = 'A';

            if (obj.Marks >= 80 && obj.Marks < 90)
                obj.Grade = 'B';

            if (obj.Marks >= 70 && obj.Marks < 80)
                obj.Grade = 'C';

            if (obj.Marks < 70)
                obj.Grade = 'D';
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} Marks: {Marks} Grade: {Grade}");
        }
    }
}
