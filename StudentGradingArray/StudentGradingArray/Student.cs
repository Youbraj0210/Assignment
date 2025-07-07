using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingArray
{
    internal class Student
    {
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public int[] Marks { get; set; }

        private double averageMarks = 0;

        public Student(string name, int studentId, int[] marks)
        {
            StudentName = name;
            StudentId = studentId;
            Marks = marks;
            averageMarks = CalculateAverage(marks);

        }

        public static string CalculateGrade(double avgMark)
        {
            if (avgMark >= 90 && avgMark <= 100)
            {
                return "A+";
            }
            if (avgMark >= 80 && avgMark <= 89)
            {
                return "A";
            }
            if (avgMark >= 70 && avgMark <= 79)
            {
                return "B";
            }
            if (avgMark >= 60 && avgMark <= 69)
            {
                return "C";
            }
            if (avgMark >= 50 && avgMark <= 59)
            {
                return "D";
            }

            return "Fail";
        }

        public static double CalculateAverage(int[] marks)
        {
            int sum = 0;

            foreach (int mark in marks)
            {
                sum += mark;
            }

            return sum / marks.Length;
        }

        public void ReportCard()
        {
            Console.WriteLine("Student Report Card");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name    : {StudentName}");
            Console.WriteLine($"Roll no : {StudentId}");
            Console.WriteLine($"marks   : [{string.Join(",",Marks)}]");
            Console.WriteLine($"Average : {averageMarks}");
            Console.WriteLine($"Grade   : {CalculateGrade(averageMarks)}");

        }

    }
}
