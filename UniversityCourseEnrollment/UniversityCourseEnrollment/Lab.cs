using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    internal class Lab : ICourse
    {
        public int SafetyCertificate;
        public string CourseName;
        public void GetCourseDetails()
        {
            Console.WriteLine("Enter course name");
            this.CourseName = (Console.ReadLine());
            Console.WriteLine("Enter Safety Training Certificate No");
            this.SafetyCertificate = Convert.ToInt32(Console.ReadLine());


        }
        public void DisplayDetails()
        {
            Console.WriteLine($" Course Name  : {CourseName} , Safety Training Completition Certificate : {SafetyCertificate}");
        }
    }
}