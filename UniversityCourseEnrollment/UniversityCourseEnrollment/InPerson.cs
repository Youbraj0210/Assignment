using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    internal class InPerson : ICourse
    {
        public string CourseName;
        public int RoomNo;
        public int Capacity;


        public void GetCourseDetails()
        {
            Console.WriteLine("Enter course name");
            this.CourseName = Console.ReadLine();
            Console.WriteLine("Enter Room No");
            this.RoomNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Capacity");
            this.Capacity = Convert.ToInt32(Console.ReadLine());


        }
        public void DisplayDetails()
        {
            Console.WriteLine($" Course Name : {CourseName} , RoomNo : {RoomNo} , Capacity: {Capacity}");
        }
    }
}