namespace UniversityCourseEnrollment
{
    internal class Program
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\nEnter the type of course want to Add (Online / In Person / Lab): ");
            string courseType = Console.ReadLine().ToLower();

            switch (courseType)
            {
                case "online":
                    Online online = new Online();
                    online.GetCourseDetails();
                    online.DisplayDetails();
                    break;

                case "in person":
                    InPerson person = new InPerson();
                    person.GetCourseDetails();
                    person.DisplayDetails();
                    break;

                case "lab":
                    Lab lab = new Lab();
                    lab.GetCourseDetails();
                    lab.DisplayDetails();
                    break;

                default:
                    Console.WriteLine("Enter valid course type");
                    break;
            }
        }
        static void Main(string[] args)
        {
            ShowMenu();
        }
    }
}
