using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    internal class Online :ICourse
    {
        public string VideoPlatformLink;
        public string CourseName;


        public void GetCourseDetails()
        {
            Console.WriteLine("Enter course name");
            this.CourseName = Console.ReadLine();
            Console.WriteLine("Enter video  Platform Link");
            this.VideoPlatformLink = Console.ReadLine();


        }
        public void DisplayDetails()
        {
            Console.WriteLine($" Course Name : {CourseName} , VideoPlatform Link : {VideoPlatformLink}");
        }
    }
}